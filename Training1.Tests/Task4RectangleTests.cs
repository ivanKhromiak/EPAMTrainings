using NUnit.Framework;

namespace Training1.Tests
{
    [TestFixture]
    public class Task4RectangleTests
    {
        [Test]
        public void RectanglePerimeterTest()
        {
            int perimeter = Task4.Rectangle.Perimeter(-5, 5, 10, -5);

            Assert.AreEqual(50, perimeter);
        }

        [Test]
        public void RectangleAreaTest()
        {
            int area = Task4.Rectangle.Area(-5, 5, 10, -5);

            Assert.AreEqual(150, area);
        }
    }
}