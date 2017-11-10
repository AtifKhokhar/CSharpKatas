using System;
using NUnit;
using NUnit.Framework;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class RomanNumeralConverterShould
    {
        [Test]
        public void ConvertNormalNumberToRomanNumeral()
        {
            //arrange
            var sut = new RomanNumeralConverter();
            var expectedOutput = 'I';
            //act
            var actualOutput = sut.ConvertNumber(1);
            //assert
            Assert.That(actualOutput.Equals(expectedOutput));
        }
    }
}
