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
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        public void ShouldParseRomanStringIntoInteger(string romanValue, int integerValue)
        {
            //Arrange & Act
            int returnedValue = Program.ParseRomanNumeral(romanValue);

            //Assert
            Assert.AreEqual(integerValue, returnedValue);

        }
    }
}