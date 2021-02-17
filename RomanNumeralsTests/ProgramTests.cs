using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class ProgramTests
    {
        //[SetUp]
        //public void Setup()
        //{
            
        //}

        [Test]
        [TestCase("I", 1)]
        [TestCase("i", 1)]
        [TestCase("II", 2)]
        [TestCase("Ii", 2)]
        [TestCase("III", 3)]
        [TestCase("V", 5)]
        [TestCase("C", 100)]
        [TestCase("L", 50)]
        [TestCase("v", 5)]
        [TestCase("l", 50)]
        public void ShouldParseRomanStringIntoInteger(string romanValue, int integerValue)
        {
            //Arrange & Act
            int returnedValue = Program.ParseRomanNumeral(romanValue);

            //Assert
            Assert.AreEqual(integerValue, returnedValue);

        }

        [Test]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XIV", 14)]
        [TestCase("XIX", 19)]
        [TestCase("XXIV", 24)]
        [TestCase("XL", 40)]
        [TestCase("XC",90)]
        [TestCase("CXC",190)]
        public void ShouldParseRomanStringIntoIntegerSubtraction(string romanValue, int integerValue)
        {
            //Arrange & Act
            int returnedValue = Program.ParseRomanNumeral(romanValue);

            //Assert
            Assert.AreEqual(integerValue, returnedValue);

        }

        
    }
}