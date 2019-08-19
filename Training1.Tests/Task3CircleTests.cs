using NUnit.Framework;

namespace Training1.Tests
{
    [TestFixture]
    public class Task3CircleTests
    {
        [Test]
        public void CircleCircumferenceTest()
        {
            var circle = new Task3.Circle(25.5);

            Assert.AreEqual(160.14, circle.Circumference, 2);
        }

        [Test]
        public void CircleAreaTest()
        {
            var circle = new Task3.Circle(25.5);

            Assert.AreEqual(2041.78, circle.Area, 2);
        }
    }
}