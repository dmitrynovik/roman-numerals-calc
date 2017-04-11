using NUnit.Framework;

namespace RomanNumbers.UnitTest
{
    [TestFixture]
    public class RomanTranslatorTest
    {
        [Test]
        public void When_0_Then_EmptyString()
        {
            var result = 0.ToRomans();
            Assert.AreEqual("", result);
        }
    }
}
