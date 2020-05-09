namespace Charming.Tests.Extensions
{
    using FluentAssertions;
    using Xunit;

    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData(null, "")]
        [InlineData("ab", "ab")]
        [InlineData("-a-b-", "ab")]
        public void DeDash_ShouldReturnValueWithoutDashes(string sut, string expected)
        {
            // Act
            var result = sut.DeDash();

            // Assert
            result.Should().Be(expected);
        }
    }
}
