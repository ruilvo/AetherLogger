namespace AetherLogger.Models.Tests;

public class LocationTests
{
    [Test]
    public void SomeDecimalCoordinatesToDMS()
    {
        double value = 41.063;
        DMS expected = new() { Degrees = 41, Minutes = 3, Seconds = 46.8 };

        DMS actual = new(value);

        Assert.Multiple(() =>
        {
            Assert.That(actual.Degrees, Is.EqualTo(expected.Degrees));
            Assert.That(actual.Minutes, Is.EqualTo(expected.Minutes));
            Assert.That(actual.Seconds, Is.EqualTo(expected.Seconds).Within(1).Percent);
        });
    }

    [Test]
    public void NegativeDecimalCoordinatesToDMS()
    {
        double value = -41.063;
        DMS expected = new() { Degrees = -41, Minutes = -3, Seconds = -46.8 };

        DMS actual = new(value);

        Assert.Multiple(() =>
        {
            Assert.That(actual.Degrees, Is.EqualTo(expected.Degrees));
            Assert.That(actual.Minutes, Is.EqualTo(expected.Minutes));
            Assert.That(actual.Seconds, Is.EqualTo(expected.Seconds).Within(0.5).Percent);
        });
    }

    [Test]
    public void ConvertToAndFromDMSShouldDoNothing()
    {
        double value = 41.063;
        DMS sample = new(value);

        double result = sample.DecimalDegrees;

        Assert.That(value, Is.EqualTo(result).Within(0.5).Percent);
    }

    [Test]
    public void ConvertToAndFromDMSShouldDoNothingForNegativeValues()
    {
        double value = -41.063;
        DMS sample = new(value);

        double result = sample.DecimalDegrees;

        Assert.That(value, Is.EqualTo(result).Within(0.5).Percent);
    }
}