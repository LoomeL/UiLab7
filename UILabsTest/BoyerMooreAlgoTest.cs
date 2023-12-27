namespace UILabsTest;

public class BoyerMooreAlgoTest
{
    [Theory]
    [InlineData("Example text for searching", "text", true)]
    [InlineData("Hello world", "world", true)]
    [InlineData("Lorem ipsum dolor sit amet", "ipsum", true)]
    [InlineData("This is a test", "is", true)]
    [InlineData("abcde", "abcd", true)]
    [InlineData("abcde", "bcde", true)]
    [InlineData("abcde", "cdef", false)]
    [InlineData("abcde", "abcde", true)]
    [InlineData("sdgjh", "text", false)]
    [InlineData("Example text for searching", "asc", false)]
    public void Test1(string search, string pattern, bool expected)
    {
        BoyerMooreAlgo boyerMooreAlgo = new BoyerMooreAlgo(pattern);
        var result = boyerMooreAlgo.Search(search, pattern);
        Assert.Equal(result.Count > 0, expected);
    }
}