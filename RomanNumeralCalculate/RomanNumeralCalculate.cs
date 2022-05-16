using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralCalculate
{
    public class RomanNumeralCalculate
    {
        private readonly RomanNumeral romanNumeral;

        public RomanNumeralCalculate(RomanNumeral romanNumeral)
        {
            this.romanNumeral = romanNumeral;
        }

        public int Calculate(string input)
        {
            var result = 0;

            if (string.IsNullOrWhiteSpace(input))
                return result;

            for (int i = 0; i < input.Length; i++)
            {
                var romanSymbol = romanNumeral.GetSymbol(input[i]);

                if (IsSubtraction(i, input))
                    result -= romanSymbol.Value;
                else
                    result += romanSymbol.Value;
            }

            return result;
        }

        private bool IsSubtraction(int currentIndex, string input)
        {
            var nextIndex = currentIndex + 1;

            if (nextIndex + 1 > input.Length)
                return false;

            var currentSymbol = romanNumeral.GetSymbol(input[currentIndex]);

            var nextSymbol = romanNumeral.GetSymbol(input[nextIndex]);

            if (nextSymbol.Value > currentSymbol.Value)
                return true;

            return false;
        }
    }
}
