using NUnit.Framework;
using System.Collections.Generic;

namespace Training3.Tests
{
    [TestFixture]
    public class Task1Tests
    {
        [Test]
        public void AddingSixPersonsTest()
        {
            List<Person> persons;

            persons = Task1.GetListPersons();

            Assert.IsNotNull(persons);
            Assert.AreEqual(6, persons.Count);
        }
    }
}