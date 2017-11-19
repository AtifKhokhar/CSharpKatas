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
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(19, "XIX")]
        public void ConvertNormalNumberToRomanNumeral(int input, string expectedOutput)
        {
            //arrange
            var sut = new RomanNumeralConverter();
            //act
            var actualOutput = sut.ConvertNumber(input);
            //assert
            Assert.That(actualOutput.Equals(expectedOutput));
        }

    }
}
