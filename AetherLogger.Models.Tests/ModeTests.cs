namespace AetherLogger.Models.Tests;

[TestFixture]
public class ModeTests
{
    [Test]
    public void DifferentModesHaveDifferentSubModes()
    {
        var lsb = Mode.SSB.Submodes?.First().Name;
        var asci = Mode.RTTY.Submodes?.First().Name;
        var am = Mode.AM.Submodes;
        Assert.Multiple(() =>
        {
            Assert.That(lsb, Is.EqualTo("LSB"));
            Assert.That(asci, Is.EqualTo("ASCI"));
            Assert.That(am, Is.Null);
        });
    }
}