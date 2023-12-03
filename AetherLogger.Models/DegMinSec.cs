namespace AetherLogger.Models;

public struct DegMinSec
{
    public double Degrees { get; set; }
    public double Minutes { get; set; }
    public double Seconds { get; set; }

    public DegMinSec(double value)
    {
        Degrees = Math.Floor(value);
        Minutes = Math.Floor((value - Degrees) * 60);
        Seconds = (value - Degrees - Minutes / 60.0) * 3600.0;
    }

    public readonly double ToDecimalDegrees()
    {
        return Degrees + Minutes / 60.0 + Seconds / 3600.0;
    }
}
