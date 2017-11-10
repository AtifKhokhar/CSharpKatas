using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanNumeralConverter
    {
        private Dictionary<int, Char> romanNumeralsDictionary = new Dictionary<int, char>()
        {
            {1, 'I'}
            
        };
    

    public RomanNumeralConverter()
        {
        }

        public Char ConvertNumber(int i)
        {
            Char romanNumeral;
            romanNumeralsDictionary.TryGetValue(i, out romanNumeral);
            return romanNumeral;
        }
    }
}