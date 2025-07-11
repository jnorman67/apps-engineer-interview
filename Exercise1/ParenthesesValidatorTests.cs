using Xunit;

namespace Exercise1.Tests;

public class ParenthesesValidatorTests
{
    [Theory]
    [InlineData("", true)]  // Empty string
    public void AreParenthesesBalanced_ShouldReturnExpectedResult(string input, bool expected)
    {
        // Act
        bool result = ParenthesesValidator.AreParenthesesBalanced(input);

        // Assert
        Assert.Equal(expected, result);
    }
}