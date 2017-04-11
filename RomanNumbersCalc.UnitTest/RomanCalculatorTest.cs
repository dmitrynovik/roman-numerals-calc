using NUnit.Framework;
using RomanNumbersCalc;

namespace RomanCalculator.UnitTest
{
    [TestFixture]
    public class RomanCalculatorTest
    {
        [Test]
        public void When_I_And_I_Then_II()
        {
            Assert.AreEqual("II", "I".AddRoman("I"));
        }

        [Test]
        public void When_XX_And_II_Then_XXII()
        {
            Assert.AreEqual("XXII", "XX".AddRoman("II"));
        }

        [Test]
        public void When_I_And_V_Then_VI()
        {
            Assert.AreEqual("VI", "I".AddRoman("V"));
        }

        [Test]
        public void When_II_And_II_Then_IV()
        {
            Assert.AreEqual("IV", "II".AddRoman("II"));
        }

        [Test]
        public void When_CCC_And_CCC_Then_DC()
        {
            Assert.AreEqual("DC", "CCC".AddRoman("CCC"));
        }

        [Test]
        public void When_D_And_D_Then_M()
        {
            Assert.AreEqual("M", "D".AddRoman("D"));
        }
    }
}
