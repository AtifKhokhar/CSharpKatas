using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class RomanNumeralConverterShould
    {
        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void ConvertNormalNumberToRomanNumeral(int input, string expectedOutput)
        {
            //arrange
            var sut = new RomanNumeralConverter();
            expectedOutput = "I";
            //act
            var actualOutput = sut.ConvertNumber(input);
            //assert
            Assert.That(actualOutput.Equals(expectedOutput));
        }

    }
}
