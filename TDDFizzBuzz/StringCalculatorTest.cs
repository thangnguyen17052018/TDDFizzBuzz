using System;
using CoreConsole;
using NUnit.Framework;

namespace TDDFizzBuzz
{
    [TestFixture]
    public class StringCalculatorTest
    {
        private StringCalculator calculator;

        [OneTimeSetUp]
        public void SetUp()
        {
            calculator = new StringCalculator();
        }

        [Test]
        public void EmptyStringTest()
        {
            var actual = calculator.Add("");
            var expect = 0;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void OneNumberTest()
        {

            var actual = calculator.Add("1");
            var expect = 1;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void TwoNumbersTest()
        {

            var actual = calculator.Add("1,2");
            var expect = 3;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void MultipleNumbersTest()
        {

            var actual = calculator.Add("1,2,3,4");
            var expect = 10;

            Assert.That(actual, Is.EqualTo(expect));
        }
        
        [Test]
        public void NewLinesBetweenNumbersTest()
        {

            var actual = calculator.Add("1\n2\n3\n4");
            var expect = 10;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void CommaAndNewLineTest()
        {

            var actual = calculator.Add("1\n2, 3");
            var expect = 6;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void CommaAndNewLineNotOKTest()
        {
            // Assign
            var expect = 1;
            // Act
            var actual = calculator.Add("1,\n");
            // Assert
            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void DifferentDelimitersTest()
        {

            var actual = calculator.Add("//;\n1;2");
            var expect = 3;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void NegativeNotAllowedTest()
        {
            var expect = "negative not allowed - (-1)";

            Assert.That(() => calculator.Add("-1, 2"), Throws.Exception);

            var exception = Assert.Throws<Exception>(() => calculator.Add("-1, 2"));
            Assert.That(exception?.Message, Is.EqualTo(expect));
        } 
        
        [Test]
        public void MultipleNegativeNotAllowedTest()
        {
            var expect = "negative not allowed - (-1,-2,-5,-6)";

            Assert.That(() => calculator.Add("-1, -2, 3, 4, -5, -6"), Throws.Exception);

            var exception = Assert.Throws<Exception>(() => calculator.Add("-1, -2, 3, 4, -5, -6"));
            Assert.That(exception?.Message, Is.EqualTo(expect));
        }

        [Test]
        public void BiggerThan1000Test()
        {
            var actual = calculator.Add("2, 1001");
            var expect = 2;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void DelimetersTest()
        {
            var actual = calculator.Add("//[***]\n1***2***3");
            var expect = 6;

            Assert.That(actual, Is.EqualTo(expect));
        }
        
        [Test]
        public void MultipleDelimetersTest()
        {
            var actual = calculator.Add("//[*][%]\n1*2%3");
            var expect = 6;

            Assert.That(actual, Is.EqualTo(expect));
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultipleDelimetersAnyLengthTest()
        {
            var actual = calculator.Add("//[*mfkllaas][%adsfmlaf]\n1*2%3[%adsfmlaf]");
            var expect = 6;

            Assert.That(actual, Is.EqualTo(expect));
        }
    }
}