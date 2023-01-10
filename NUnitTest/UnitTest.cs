using SlittaDLL;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_AggiungiRegalo()
        {
            Slitta slitta = new Slitta(150.56, 236.67);
            Regalo computer = new Regalo(100.56, 100.07, "nero", "computer");
            Regalo libro = new Regalo(25.5, 100.60, "giallo", "libro");
            Regalo zaino = new Regalo(24.5, 36, "rosso", "zaino");

            Assert.That(slitta.AggiungiRegalo(computer), Is.EqualTo(true));
            Assert.That(slitta.AggiungiRegalo(libro), Is.EqualTo(true));
            Assert.That(slitta.AggiungiRegalo(zaino), Is.EqualTo(true));
            Assert.That(slitta.AggiungiRegalo(zaino), Is.EqualTo(false));
        }
    }
}
