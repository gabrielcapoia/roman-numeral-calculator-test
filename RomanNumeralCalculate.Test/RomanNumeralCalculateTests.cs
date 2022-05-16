using System;
using Xunit;

namespace RomanNumeralCalculate.Test
{
    public class RomanNumeralCalculateTests
    {
        [Theory]
        [InlineData('I', 1)]
        [InlineData('V', 5)]
        [InlineData('X', 10)]
        [InlineData('L', 50)]
        [InlineData('C', 100)]
        [InlineData('D', 500)]
        [InlineData('M', 1000)]
        public void RomanNumeral_Calculate_ShouldReturnRightValueForSingleSymbol(char symbol, int value)
        {
            //Arrange
            var calculator = new RomanNumeralCalculate(new RomanNumeral());

            //Act
            var result = calculator.Calculate(symbol.ToString());

            //Assert
            Assert.Equal(value, result);
        }

        [Theory]
        [InlineData("III", 3)]
        [InlineData("VIII", 8)]
        [InlineData("XV", 15)]
        [InlineData("LXX", 70)]
        [InlineData("CLXIII", 163)]
        [InlineData("DCX", 610)]
        [InlineData("MMXXII", 2022)]
        public void RomanNumeral_Calculate_ShouldReturnRightValueForMoreThanOneSymbolWithoutSubtractionCase(string romanNumeral, int value)
        {
            //Arrange
            var calculator = new RomanNumeralCalculate(new RomanNumeral());

            //Act
            var result = calculator.Calculate(romanNumeral);

            //Assert
            Assert.Equal(value, result);
        }

        [Theory]
        [InlineData("IV", 4)]
        [InlineData("XLIII", 43)]
        [InlineData("MCMXCIV", 1994)]        
        public void RomanNumeral_Calculate_ShouldReturnRightValueForMoreThanOneSymbolWithSubtractionCase(string romanNumeral, int value)
        {
            //Arrange
            var calculator = new RomanNumeralCalculate(new RomanNumeral());

            //Act
            var result = calculator.Calculate(romanNumeral);

            //Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void RomanNumeral_Calculate_ShouldReturnZeroForEmptyString()
        {
            //Arrange
            var calculator = new RomanNumeralCalculate(new RomanNumeral());

            //Act
            var result = calculator.Calculate(string.Empty);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void RomanNumeral_Calculate_ShouldThrowSymbolNotFoundExceptionForUnknowingSymbol()
        {
            //Arrange
            var calculator = new RomanNumeralCalculate(new RomanNumeral());

            //Act & Assert
            Assert.Throws<RomanSymbolNotFoundException>(() => calculator.Calculate("K"));            
        }
    }
}
