using NUnit.Framework;

namespace Training1.Tests
{
    [TestFixture]
    public class Task4CircleTests
    {
        [Test]
        public void CircleCircumferenceTest()
        {
            double circumference = Task4.Circle.Circumference(15.6);

            Assert.AreEqual(97.96, circumference, 2);
        }

        [Test]
        public void CircleAreaTest()
        {
            double area = Task4.Circle.Area(15.6);

            Assert.AreEqual(764.15, area, 2);
        }
    }
}