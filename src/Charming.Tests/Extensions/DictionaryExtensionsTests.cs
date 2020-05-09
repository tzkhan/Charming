namespace Charming.Tests.Extensions
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class DictionaryExtensionsTests
    {
        [Fact]
        public void ToStringOutputValueDictionary_ShouldReturnDictionaryWithStringKeyAndStringOutputValueValue()
        {
            // Arrange
            var key = "key";
            var value = "value";

            // Act
            var result = new Dictionary<string, string> { { key, value } }.ToStringOutputValueDictionary();

            // Assert
            result.Should().BeOfType<Dictionary<string, OutputValue>>();
            result.Should().ContainKey(key);
            result[key].Should().BeOfType<StringOutputValue>();
            result[key].HasValue.Should().BeTrue();
            result[key].As<StringOutputValue>().IsObject.Should().BeFalse();
            result[key].As<StringOutputValue>().IsSecure.Should().BeFalse();
            result[key].As<StringOutputValue>().Value.Should().Be(value);
        }
    }
}
