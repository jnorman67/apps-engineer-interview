using Xunit;

namespace Exercise1.Tests;

public class ParenthesesValidatorTests
{
    [Theory]
    [InlineData("", true)]  // Empty string
    public void AreParenthesesValid_ShouldReturnExpectedResult(string input, bool expected)
    {
        // Act
        bool result = ParenthesesValidator.AreParenthesesValid(input);

        // Assert
        Assert.Equal(expected, result);
    }
}