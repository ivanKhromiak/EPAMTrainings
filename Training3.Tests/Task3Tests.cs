using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Training3.Tests
{
    [TestFixture]
    class Task3Tests
    {
        [Test]
        public void LengthIsFourTest()
        {
            var random = new Random();

            string test = Task3.GenerateString(random);

            Assert.AreEqual(4, test.Length);
        }

        [Test]
        public void AllLettersIsUpperCaseTest()
        {
            var random = new Random();

            string test = Task3.GenerateString(random);

            foreach (char letter in test)
            {
                Assert.IsTrue(char.IsUpper(letter));
            }
        }

        [Test]
        public void DeleteSameInSortedListTest()
        {
            var list = new List<string>() { "AAAA", "AAAA", "AAAA", "BBBB", "CCCC", "CCCC", "DDD", "DDD", "DDD"};
            var expectedList = new List<string>() { "AAAA", "BBBB", "CCCC", "DDD" };

            Task3.DeleteSameInSortedList(ref list);

            Assert.AreEqual(expectedList.Count, list.Count);
            Assert.AreEqual(expectedList[0], list[0]);
            Assert.AreEqual(expectedList[1], list[1]);
            Assert.AreEqual(expectedList[2], list[2]);
            Assert.AreEqual(expectedList[3], list[3]);
        }

        [Test]
        public void SortTest()
        {
            var list = new List<string>() { "AAAA", "BBBB", "CCCC" };
            var expectedList = new List<string>() { "CCCC", "BBBB", "AAAA" };

            Task3.Sort(ref list);

            Assert.AreEqual(expectedList[0], list[0]);
            Assert.AreEqual(expectedList[1], list[1]);
            Assert.AreEqual(expectedList[2], list[2]);
        }

        [Test]
        public void DeleteStartWithZTest()
        {
            var list = new List<string>() { "AAAA", "ZDDD", "ZBBB", "YFGT" };
            var expectedList = new List<string>() { "AAAA", "YFGT" };

            Task3.DeleteStartsWithZ(ref list);

            Assert.AreEqual(expectedList.Count, list.Count);
            Assert.AreEqual(expectedList[0], list[0]);
            Assert.AreEqual(expectedList[1], list[1]);
        }
    }
}
