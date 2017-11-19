using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsKata
{
    public class RomanNumeralConverter
    {
        private Dictionary<int, string> romanNumeralsDictionary = new Dictionary<int, string>()
        {
            {1, "I"},
            {5, "V"},
            {10, "X"}
        };
    

    public RomanNumeralConverter()
        {
        }

        public string ConvertNumber(int arabicNumber)
        {
            string romanNumeral = "";
            romanNumeralsDictionary.TryGetValue(arabicNumber, out romanNumeral);
            if (arabicNumber % 10 == 4 || arabicNumber % 10 == 9)
            {
                romanNumeral = this.AppendSubtractiveNotation(arabicNumber, romanNumeral);

            }
            else if (arabicNumber % 10 == 5)
            {
                romanNumeral =  this.AppendVToNumeral(arabicNumber, romanNumeral);
            }
            else
            {
                romanNumeral = this.AppendIToNumeral(arabicNumber, romanNumeral);
            }
            return romanNumeral;
        }

        private string AppendIToNumeral(int arabicNumber, string numeral)
        {
            if(string.IsNullOrEmpty(numeral)){numeral = DecideBaseNumeral(arabicNumber);}

            var baseNumeralNumber = romanNumeralsDictionary.FirstOrDefault(x => x.Value == numeral).Key;
            var appendCount = arabicNumber - baseNumeralNumber;
            for (int i = 1; i <= appendCount; i++)
            { 
                numeral = string.Concat(numeral,"I");
            }
            return numeral;
        }

        private string AppendSubtractiveNotation(int arabicNumber, string numeral)
        {
            if (string.IsNullOrEmpty(numeral)) { numeral = DecideBaseNumeral(arabicNumber); }

            if(arabicNumber % 10 == 4)
            {
                numeral += "IV";
            }
            if(arabicNumber % 10 == 9)
            {
                numeral += "IX";
            }

            return numeral;
        }

        private string AppendVToNumeral(int arabicNumber, string numeral)
        {
            if (string.IsNullOrEmpty(numeral)) { numeral = DecideBaseNumeral(arabicNumber); }

            if (arabicNumber != 5)
            {
                numeral += "V";
            }
            return numeral;
        }


        private string DecideBaseNumeral(int arabicNumber)
        {
            if(arabicNumber <= 3) 
            {
                return "I";
            }

            if(arabicNumber > 4 && arabicNumber < 9)
            {
                return "V";
            }
            if (arabicNumber >= 10)
            {
                return "X";
            }
            return null;
        }

    }
}