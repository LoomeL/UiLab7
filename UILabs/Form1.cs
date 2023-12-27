namespace UILabs;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public void searchButton_Click(object sender, EventArgs e)
    {
        if (stringSearch.Text == string.Empty) return;
        if (textBox.Text == string.Empty) return;
        BoyerMooreAlgo boyerMooreAlgo = new BoyerMooreAlgo(stringSearch.Text);
        var result = boyerMooreAlgo.Search(textBox.Text, stringSearch.Text);
        searchResult.Text = result.Count == 0 ? "Not Found" : "Found";
    }
}