using System;
using CoreConsole;
using NUnit.Framework;

namespace TDDFizzBuzz
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [Test]
        public void EmptyStringTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("");
            var expect = 0;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void OneNumberTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("1");
            var expect = 1;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void TwoNumbersTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("1,2");
            var expect = 3;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void MultipleNumbersTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("1,2,3,4");
            var expect = 10;

            Assert.That(actual, Is.EqualTo(expect));
        }
        
        [Test]
        public void NewLinesBetweenNumbersTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("1\n2\n3\n4");
            var expect = 10;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void CommaAndNewLineTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("1\n2, 3");
            var expect = 6;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void CommaAndNewLineNotOKTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("1,\n");
            var expect = 1;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void DifferentDelimitersTest()
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add("//;\n1;2");
            var expect = 3;

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void NegativeNotAllowedTest()
        {
            StringCalculator calculator = new StringCalculator();
            var expect = "negative not allowed - (-1)";

            Assert.That(() => calculator.Add("-1, 2"), Throws.Exception);

            var exception = Assert.Throws<Exception>(() => calculator.Add("-1, 2"));
            Assert.That(exception?.Message, Is.EqualTo(expect));
        } 
        
        [Test]
        public void MultipleNegativeNotAllowedTest()
        {
            StringCalculator calculator = new StringCalculator();
            var expect = "negative not allowed - (-1,-2,-5,-6)";

            Assert.That(() => calculator.Add("-1, -2, 3, 4, -5, -6"), Throws.Exception);

            var exception = Assert.Throws<Exception>(() => calculator.Add("-1, -2, 3, 4, -5, -6"));
            Assert.That(exception?.Message, Is.EqualTo(expect));
        }

        [Test]
        public void BiggerThan1000Test()
        {
            StringCalculator calculator = new StringCalculator();
            var actual = calculator.Add("2, 1001");
            var expect = 2;

            Assert.That(actual, Is.EqualTo(expect));
        }



    }
}