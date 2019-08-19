using NUnit.Framework;
using System;

namespace Training1.Tests
{
    [TestFixture]
    public class Task5ComplexNumber
    {
        [Test]
        public void MultiplicationTest()
        {
            var number1 = new Task5.ComplexNumber(4, 6);
            var number2 = new Task5.ComplexNumber(13, -2);
            var expected = new Task5.ComplexNumber(64, 70);

            Task5.ComplexNumber result = number1 * number2;

            Assert.AreEqual(expected.RealPart, result.RealPart, 2);
            Assert.AreEqual(expected.ImaginaryPart, result.ImaginaryPart, 2);
        }

        [Test]
        public void DivisionTest()
        {
            var number1 = new Task5.ComplexNumber(4, 6);
            var number2 = new Task5.ComplexNumber(13, -2);
            var expected = new Task5.ComplexNumber(0.23, 0.49);

            Task5.ComplexNumber result = number1 / number2;

            Assert.AreEqual(expected.RealPart, result.RealPart, 2);
            Assert.AreEqual(expected.ImaginaryPart, result.ImaginaryPart, 2);
        }

        [Test]
        public void DividingByZeroTest()
        {
            var number1 = new Task5.ComplexNumber(-4, 6);
            var number2 = new Task5.ComplexNumber(0, 0);

            Task5.ComplexNumber result;

            Assert.Throws<DivideByZeroException>(() => result = number1 / number2);
        }
    }
}