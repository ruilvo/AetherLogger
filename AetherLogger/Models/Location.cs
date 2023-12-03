namespace AetherLogger.Models;

public struct DMS
{
    public int Degrees { get; set; }
    public int Minutes { get; set; }
    public double Seconds { get; set; }

    public DMS(double value)
    {
        Degrees = (int)value;
        Minutes = (int)((value - Degrees) * 60);
        Seconds = (double)((value - Degrees - Minutes / 60.0) * 3600);
    }
}
