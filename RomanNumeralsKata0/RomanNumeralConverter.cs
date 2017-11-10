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
            {1, "I"}
            
        };
    

    public RomanNumeralConverter()
        {
        }

        public string ConvertNumber(int arabicNumber)
        {
            string romanNumeral;
            romanNumeralsDictionary.TryGetValue(1, out romanNumeral);
            romanNumeral = this.AppendIToNumeral(arabicNumber, romanNumeral);
            return romanNumeral;
        }

        private string AppendIToNumeral(int arabicNumber, string numeral)
        {
            StringBuilder builder = new StringBuilder();
            if(arabicNumber > 1 && arabicNumber <= 3)
            {
                for (int i = 0; i < arabicNumber; i++)
                    return builder.Append(numeral).ToString();

            }
            return numeral;
                
        }


    }
}