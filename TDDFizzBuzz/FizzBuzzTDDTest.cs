using CoreConsole;
using NUnit.Framework;

namespace TDDFizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFizz()
        {
            var actual = FizzBuzz.FizzBuzzPrint(3);
            var expect = "Fizz";

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void TestBuzz()
        {
            var actual = FizzBuzz.FizzBuzzPrint(5);
            var expect = "Buzz";

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void TestFizzBuzz()
        {
            var actual = FizzBuzz.FizzBuzzPrint(15);
            var expect = "FizzBuzz";

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void TestOthers()
        {
            var actual = FizzBuzz.FizzBuzzPrint(4);
            var expect = "4";

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void NegativeTest()
        {
            var actual = FizzBuzz.FizzBuzzPrint(-1);
            var expect = "-1";

            Assert.That(actual, Is.EqualTo(expect));
        }
        
        [Test]
        public void NegativeFizzTest()
        {
            var actual = FizzBuzz.FizzBuzzPrint(-3);
            var expect = "Fizz";

            Assert.That(actual, Is.EqualTo(expect));
        }
        
        [Test]
        public void NegativeBuzzTest()
        {
            var actual = FizzBuzz.FizzBuzzPrint(-5);
            var expect = "Buzz";

            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void NegativeFizzBuzzTest()
        {
            var actual = FizzBuzz.FizzBuzzPrint(-15);
            var expect = "FizzBuzz";

            Assert.That(actual, Is.EqualTo(expect));
        }


    }
}