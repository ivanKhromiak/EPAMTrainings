using NUnit.Framework;

namespace Training1.Tests
{
    [TestFixture]
    public class Task1RectangleTests
    {
        [Test]
        public void RectanglePerimeterTest()
        {
            var rectangle = new Task1.Rectangle(0, 10, 10, 5);

            Assert.AreEqual(30, rectangle.Perimeter);
        }

        [Test]
        public void RectangleAreaTest()
        {
            var rectangle = new Task1.Rectangle(0, 10, 10, 5);

            Assert.AreEqual(50, rectangle.Area);
        }
    }
}