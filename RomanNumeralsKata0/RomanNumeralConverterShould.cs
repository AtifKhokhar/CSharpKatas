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
