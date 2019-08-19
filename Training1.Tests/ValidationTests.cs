using NUnit.Framework;

namespace Training1.Tests
{
    [TestFixture]
    public class ValidationTests
    {
        [Test]
        public void VlidationOfRectangleTest()
        {
            Assert.AreEqual(false, Validation.ValidateRectangle(5, 5, 5, 6));
            Assert.AreEqual(false, Validation.ValidateRectangle(8, 2, 5, 2));
            Assert.AreEqual(false, Validation.ValidateRectangle(0, 0, 0, 0));
            Assert.AreEqual(false, Validation.ValidateRectangle(-5, -5, -4, -4));
            Assert.AreEqual(true, Validation.ValidateRectangle(-6, -6, -5, -8));
        }

        [Test]
        public void VlidationOfCircleTest()
        {
            Assert.AreEqual(false, Validation.ValidateCircle(-5.6));
            Assert.AreEqual(false, Validation.ValidateCircle(0));
            Assert.AreEqual(true, Validation.ValidateCircle(1345));
        }
    }
}