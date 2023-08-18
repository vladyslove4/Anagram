using System;
using Anagram.Services;

namespace TextReverseTests;
public class ReverseTextServiceTests
{
    public ReverseTextServiceTests()
    {


    }

    ReverseTextService service = new();

    [Theory]
    [InlineData("Hello world", "olleH dlrow")]
    [InlineData("   hello   ", "   olleh   ")]
    [InlineData(" hell0  w0rld", " lleh0  d0lrw")]
    [InlineData("123 456", "123 456")]
    [InlineData("1a", "1a")]
    [InlineData(" ", " ")]
    [InlineData("@#$%^&*()_", "@#$%^&*()_")]

    public void ReverseText_DataIsPassed_ReturnsReversedString(string input, string expected)
    {
        //arrange
        //act
        var actualResult = service.ReverseText(input);
        //asset
        Assert.Equal(expected, actualResult);
    }

    [Fact]
    public void ReverseText_NotValidDataIsPassed_ReturnsData()
    {
        //arrange
        string? input = null;
        //act
        //asset
        Assert.Throws<ArgumentNullException>(() => service.ReverseText(input));
    }
}