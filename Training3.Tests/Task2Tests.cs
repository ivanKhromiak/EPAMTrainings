using NUnit.Framework;
using System.Collections.Generic;

namespace Training3.Tests
{
    [TestFixture]
    public class Task2Tests
    {
        [Test]
        public void AddingTwoPersonsTest()
        {
            var persons = new List<Person>();

            Task2.AddRangePersons(ref persons);

            Assert.IsNotNull(persons);
            Assert.AreEqual(2, persons.Count);
        }
    }
}