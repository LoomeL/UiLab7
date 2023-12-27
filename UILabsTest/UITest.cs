using System.Windows.Forms;

namespace UILabsTest;

public class UITest
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
        Form1 form = new Form1();
        
        var stringSearch = form.Controls.Find("stringSearch", true).FirstOrDefault() as TextBox;
        var textBox = form.Controls.Find("textBox", true).FirstOrDefault() as TextBox;
        var searchButton = form.Controls.Find("searchButton", true).FirstOrDefault() as Button;
        var searchResult = form.Controls.Find("searchResult", true).FirstOrDefault() as Label;

        if (stringSearch == null || textBox == null || searchButton == null || searchResult == null)
        {
            Assert.Fail("Controls not found");
        }
        
        stringSearch.Text = pattern;
        textBox.Text = search;

        form.searchButton_Click(searchButton, EventArgs.Empty);
        
        Assert.Equal(expected ? "Found" : "Not Found", searchResult.Text);
    }
}