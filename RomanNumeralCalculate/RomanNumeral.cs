using System.Collections.Generic;

namespace RomanNumeralCalculate
{
    public class RomanNumeral
    {
        public Dictionary<char, RomanSymbol> Symbols { get; set; }

        public RomanNumeral()
        {
            this.Symbols = LoadSymbols();
        }

        public RomanSymbol GetSymbol(char value) {
            var symbol = Symbols.GetValueOrDefault(value);

            if (symbol == null)
                throw new RomanSymbolNotFoundException();

            return symbol;
        }

        private Dictionary<char, RomanSymbol> LoadSymbols()
        {
            var symbols = new Dictionary<char, RomanSymbol>
            {
                { 'I', new RomanSymbol() { Symbol = 'I', Value = 1 } },
                { 'V', new RomanSymbol() { Symbol = 'V', Value = 5 } },
                { 'X', new RomanSymbol() { Symbol = 'X', Value = 10 } },
                { 'L', new RomanSymbol() { Symbol = 'L', Value = 50 } },
                { 'C', new RomanSymbol() { Symbol = 'C', Value = 100 } },
                { 'D', new RomanSymbol() { Symbol = 'D', Value = 500 } },
                { 'M', new RomanSymbol() { Symbol = 'M', Value = 1000 } }
            };

            return symbols;
        }
    }
}
