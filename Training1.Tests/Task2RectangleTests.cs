using NUnit.Framework;

namespace Training1.Tests
{
    [TestFixture]
    public class Task2RectangleTests
    {
        [Test]
        public void RectanglePerimeterTest()
        {
            var rectangle = new Task2.Rectangle(-10, 10, 0, 5);

            Assert.AreEqual(30, rectangle.Perimeter);
        }

        [Test]
        public void RectangleAreaTest()
        {
            var rectangle = new Task2.Rectangle(-10, 10, 0, 5);

            Assert.AreEqual(50, rectangle.Area);
        }
    }
}