// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

namespace AetherLogger.Models.Location;

public readonly struct DegMinSec
{
    public double Degrees { get; init; }
    public double Minutes { get; init; }
    public double Seconds { get; init; }

    public DegMinSec(double value)
    {
        Degrees = (int)value;
        Minutes = (int)((value - Degrees) * 60);
        Seconds = (value - Degrees - Minutes / 60.0) * 3600.0;
    }

    public readonly double ToDecimalDegrees()
    {
        return Degrees + Minutes / 60.0 + Seconds / 3600.0;
    }

    public static double ToDecimalDegrees(double degrees, double minutes, double seconds)
    {
        return degrees + minutes / 60.0 + seconds / 3600.0;
    }
}
