using NUnit.Framework;

namespace Training1Test
{
    [TestFixture]
    public class Task1RectangleTests
    {
        [Test]
        public void RectanglePerimeterTest()
        {
            var rectangle = new Training1.Task1.Rectangle(0, 10, 10, 5);

            Assert.AreEqual(30, rectangle.Perimeter);
        }
        [Test]
        public void RectangleAreaTest()
        {
            //Arrange
            var rectangle = new Training1.Task1.Rectangle(0, 10, 10, 5);
            //Act

            //Assert
            Assert.AreEqual(50, rectangle.Area);
        }
    }
}