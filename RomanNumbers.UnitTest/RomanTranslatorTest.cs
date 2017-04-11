using NUnit.Framework;

namespace RomanNumbers.UnitTest
{
    [TestFixture]
    public class RomanTranslatorTest
    {
        [Test]
        public void When_0_Then_EmptyString()
        {
            Assert.AreEqual("", 0.ToRomans());
        }

        [Test]
        public void When_1_Then_I()
        {
            Assert.AreEqual("I", 1.ToRomans());
        }

        [Test]
        public void When_2_Then_II()
        {
            Assert.AreEqual("II", 2.ToRomans());
        }

        [Test]
        public void When_3_Then_III()
        {
            Assert.AreEqual("III", 3.ToRomans());
        }

        [Test]
        public void When_4_Then_IV()
        {
            Assert.AreEqual("IV", 4.ToRomans());
        }

        [Test]
        public void When_5_Then_V()
        {
            Assert.AreEqual("V", 5.ToRomans());
        }

        [Test]
        public void When_6_Then_VI()
        {
            Assert.AreEqual("VI", 6.ToRomans());
        }

        [Test]
        public void When_7_Then_VII()
        {
            Assert.AreEqual("VII", 7.ToRomans());
        }

        [Test]
        public void When_8_Then_VIII()
        {
            Assert.AreEqual("VIII", 8.ToRomans());
        }

        [Test]
        public void When_9_Then_IX()
        {
            Assert.AreEqual("IX", 9.ToRomans());
        }

        [Test]
        public void When_10_Then_X()
        {
            Assert.AreEqual("X", 10.ToRomans());
        }

        [Test]
        public void When_50_Then_DCC()
        {
            Assert.AreEqual("L", 50.ToRomans());
        }

        [Test]
        public void When_99_Then_XCIX()
        {
            Assert.AreEqual("XCIX", 99.ToRomans());
        }

        [Test]
        public void When_700_Then_DCC()
        {
            Assert.AreEqual("DCC", 700.ToRomans());
        }

        [Test]
        public void When_1981_Then_MCMLXXXI()
        {
            Assert.AreEqual("MCMLXXXI", 1981.ToRomans());
        }
    }
}
