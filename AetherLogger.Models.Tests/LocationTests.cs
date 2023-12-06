namespace AetherLogger.Models.Tests;

[TestFixture]
public class LocationTests
{
    [Test]
    public void SomeDecimalCoordinatesToDMS()
    {
        double value = 41.063;
        DegMinSec expected = new() { Degrees = 41, Minutes = 3, Seconds = 46.8 };

        DegMinSec result = new(value);

        Assert.Multiple(() =>
        {
            Assert.That(result.Degrees, Is.EqualTo(expected.Degrees));
            Assert.That(result.Minutes, Is.EqualTo(expected.Minutes));
            Assert.That(result.Seconds, Is.EqualTo(expected.Seconds).Within(1).Percent);
        });
    }

    [Test]
    public void NegativeDecimalCoordinatesToDMS()
    {
        double value = -41.063;
        DegMinSec expected = new() { Degrees = -41, Minutes = -3, Seconds = -46.8 };

        DegMinSec result = new(value);

        Assert.Multiple(() =>
        {
            Assert.That(result.Degrees, Is.EqualTo(expected.Degrees));
            Assert.That(result.Minutes, Is.EqualTo(expected.Minutes));
            Assert.That(result.Seconds, Is.EqualTo(expected.Seconds).Within(0.5).Percent);
        });
    }

    [Test]
    public void ConvertToAndFromDMSShouldDoNothing()
    {
        double value = 41.063;
        DegMinSec sample = new(value);

        double result = sample.ToDecimalDegrees();

        Assert.That(result, Is.EqualTo(value).Within(0.5).Percent);
    }

    [Test]
    public void ConvertToAndFromDMSShouldDoNothingForNegativeValues()
    {
        double value = -41.063;
        DegMinSec sample = new(value);

        double result = sample.ToDecimalDegrees();

        Assert.That(result, Is.EqualTo(value).Within(0.5).Percent);
    }

    [TestCase(38.59166667, -28.79750, "HM58oo")]
    [TestCase(39.434294440, -8.921988889, "IM59mk")]
    [TestCase(-88.938, -178.292, "AA01ub")]
    [TestCase(41.10634, -8.58875, "IN51QC95IM")]
    public void MaidenheadLocatorFromCoordinates(double latitude, double longitude, string expected)
    {
        Location value = new(new(longitude, latitude));
        string locator = value.ToGridSquare((Location.MaidenheadGridPrecision)expected.Length);

        Assert.That(locator, Is.EqualTo(expected.ToUpper()));
    }

    [Test]
    public void FromMaidenheadAndBackShouldBeConsistent()
    {
        string locator = "IN51QC95IM";
        string result = Location.FromGridSquare(locator)
                        .ToGridSquare((Location.MaidenheadGridPrecision)locator.Length);

        Assert.That(result, Is.EqualTo(locator));
    }
}