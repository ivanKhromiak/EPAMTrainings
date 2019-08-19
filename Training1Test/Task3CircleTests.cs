using NUnit.Framework;

namespace Training1Test
{
    [TestFixture]
    public class Task3CircleTests
    {
        [Test]
        public void CircleCircumferenceTest()
        {
            var circle = new Training1.Task3.Circle(100);

            Assert.AreEqual(628, circle.Circumference);
        }
        [Test]
        public void CircleAreaTest()
        {
            var circle = new Training1.Task3.Circle(100);

            Assert.AreEqual(31400, circle.Area);
        }
    }
}