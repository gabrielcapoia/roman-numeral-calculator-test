using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RomanNumeralCalculate.Test
{
    public class RomanNumeralTests
    {
        [Theory]
        [InlineData('I', 1)]
        [InlineData('V', 5)]
        [InlineData('X', 10)]
        [InlineData('L', 50)]
        [InlineData('C', 100)]
        [InlineData('D', 500)]
        [InlineData('M', 1000)]
        public void RomanNumeral_ShouldLoadSymbolsCorretly(char symbol, int value)
        {
            //Arrenge
            var romanNumeral = new RomanNumeral();

            //Act & Assert
            Assert.Equal(romanNumeral.GetSymbol(symbol).Symbol, symbol);
            Assert.Equal(romanNumeral.GetSymbol(symbol).Value, value);
        }

        [Fact]
        public void RomanNumeral_ShouldThrowSymbolNotFoundExceptionForUnknowingSymbol()
        {
            //Arrenge
            var romanNumeral = new RomanNumeral();

            //Act & Assert
            Assert.Throws<RomanSymbolNotFoundException>(() => romanNumeral.GetSymbol('K'));
        }
    }
}
