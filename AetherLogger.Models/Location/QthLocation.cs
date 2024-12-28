// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

using NetTopologySuite.Geometries;

using System;
using System.Diagnostics;

namespace AetherLogger.Models.Location;

public class QthLocation(Point point)
{
    public Point Coordinates { get; } = point;

    public enum MaidenheadGridPrecision
    {
        TWO = 2,
        FOUR = 4,
        SIX = 6,
        EIGHT = 8,
        TEN = 10,
        TWELVE = 12
    }

    private static (double, double) PrecisionOfMaidenheadGrid(int pairIndex)
    {

        // Character Range Span           Dimension
        // 1         A - R 20 degrees     Longitude
        // 2         A - R 10 degrees     Latitude
        // 3           9   2 degrees      Longitude
        // 4           9   1 degree       Latitude
        // 5           X   5 minutes      Longitude
        // 6           X   2.5 minutes    Latitude
        // 7           9   30 seconds     Longitude
        // 8           9   15 seconds     Latitude
        // 9           X   1.25 seconds   Longitude
        // 10          X   0.625 seconds  Latitude
        // 11          9   0.125 seconds  Longitude
        // 12          9   0.0625 seconds Latitude

        double longitudePrecision = 20.0;
        double latitudePrecision = 10.0;

        switch (pairIndex)
        {
            case 0:
                longitudePrecision = 20;
                latitudePrecision = 10;
                break;
            case 1:
                longitudePrecision = 2;
                latitudePrecision = 1;
                break;
            case 2:
                longitudePrecision = new DegMinSec { Degrees = 0, Minutes = 5, Seconds = 0 }.ToDecimalDegrees();
                latitudePrecision = new DegMinSec { Degrees = 0, Minutes = 2, Seconds = 30 }.ToDecimalDegrees();
                break;
            case 3:
                longitudePrecision = new DegMinSec { Degrees = 0, Minutes = 0, Seconds = 30 }.ToDecimalDegrees();
                latitudePrecision = new DegMinSec { Degrees = 0, Minutes = 0, Seconds = 15 }.ToDecimalDegrees();
                break;
            case 4:
                longitudePrecision = new DegMinSec { Degrees = 0, Minutes = 0, Seconds = 1.25 }.ToDecimalDegrees();
                latitudePrecision = new DegMinSec { Degrees = 0, Minutes = 0, Seconds = 0.625 }.ToDecimalDegrees();
                break;
            case 5:
                longitudePrecision = new DegMinSec { Degrees = 0, Minutes = 0, Seconds = 0.125 }.ToDecimalDegrees();
                latitudePrecision = new DegMinSec { Degrees = 0, Minutes = 0, Seconds = 0.0625 }.ToDecimalDegrees();
                break;
        }

        return (longitudePrecision, latitudePrecision);
    }

    /// <summary>
    /// Computes the QTH/Maidenhead grid square for the given coordinates.
    /// </summary>
    /// <param name="precision">How many characters to use for the Maidenhead locator.</param>
    /// <returns>The QTH/Maidenhead grid square.</returns>
    /// <remarks>
    /// See the
    /// <see href="https://www.adif.org/314/ADIF_314.htm#Maidenhead_Locator">ADIF specification</see>
    /// for more details.
    /// </remarks>
    public string ToGridSquare(MaidenheadGridPrecision precision = MaidenheadGridPrecision.SIX)
    {
        char[] qthLoc = new char[(int)precision];

        // The origin of the QTH/Maidenhead Locator system is (-90, -180) (lat, lon).
        double modifiedLongitude = Coordinates.X + 180.0;
        double modifiedLatitude = Coordinates.Y + 90.0;

        for (int i = 0; i < (int)precision; i += 2)
        {
            char charOffset = i / 2 % 2 == 0 ? 'A' : '0';

            (double longitudePrecision, double latitudePrecision) = PrecisionOfMaidenheadGrid(i / 2);

            char longitudeRemainder = (char)(modifiedLongitude / longitudePrecision);
            char latitudeRemainder = (char)(modifiedLatitude / latitudePrecision);

            modifiedLongitude %= longitudePrecision;
            modifiedLatitude %= latitudePrecision;

            qthLoc[i] = (char)(charOffset + longitudeRemainder);
            qthLoc[i + 1] = (char)(charOffset + latitudeRemainder);
        }

        return new(qthLoc);
    }

    /// <summary>
    /// Creates an instance of <see cref="QthLocation"/> from a QTH/Maidenhead locator.
    /// </summary>
    /// <param name="gridString"></param>
    /// <returns>A <see cref="QthLocation"/> object.</returns>
    /// <remarks>The coordinates generated are the centre of the square given as input.</remarks>
    public static QthLocation FromGridSquare(string gridSquare)
    {
        Debug.Assert(gridSquare.Length % 2 == 0, "The grid square must have an even number of characters.");

        string gridString = gridSquare.Trim().ToUpper();

        // Test whether the grid square is valid
        foreach (char c in gridString)
        {
            if (c < 'A' || c > 'X' && c < '0' || c > '9')
            {
                throw new ArgumentException("The grid square is not valid.", nameof(gridSquare));
            }
        }

        double longitude = 0.0;
        double latitude = 0.0;

        double longitudePrecision = 0.0;
        double latitudePrecision = 0.0;

        for (int i = 0; i < gridString.Length; i += 2)
        {
            char charOffset = i / 2 % 2 == 0 ? 'A' : '0';

            (longitudePrecision, latitudePrecision) = PrecisionOfMaidenheadGrid(i / 2);

            int longitudeCharOffset = gridString[i] - charOffset;
            int latitudeCharOffset = gridString[i + 1] - charOffset;

            longitude += longitudePrecision * longitudeCharOffset;
            latitude += latitudePrecision * latitudeCharOffset;
        }

        // Add half of the grid size to put the coordinates in the middle of the square
        longitude += longitudePrecision / 2.0;
        latitude += latitudePrecision / 2.0;

        longitude -= 180.0;
        latitude -= 90.0;

        return new(new(longitude, latitude));
    }
}
