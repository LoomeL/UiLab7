namespace UILabs;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBox = new TextBox();
        stringSearch = new TextBox();
        searchResult = new Label();
        searchButton = new Button();
        SuspendLayout();
        // 
        // textBox
        // 
        textBox.Location = new Point(12, 12);
        textBox.Name = "textBox";
        textBox.Size = new Size(271, 23);
        textBox.TabIndex = 0;
        // 
        // stringSearch
        // 
        stringSearch.Location = new Point(12, 41);
        stringSearch.Name = "stringSearch";
        stringSearch.Size = new Size(108, 23);
        stringSearch.TabIndex = 1;
        // 
        // searchResult
        // 
        searchResult.AutoSize = true;
        searchResult.Location = new Point(126, 44);
        searchResult.Name = "searchResult";
        searchResult.Size = new Size(38, 15);
        searchResult.TabIndex = 2;
        searchResult.Text = "label1";
        // 
        // searchButton
        // 
        searchButton.Location = new Point(12, 70);
        searchButton.Name = "searchButton";
        searchButton.Size = new Size(75, 23);
        searchButton.TabIndex = 3;
        searchButton.Text = "Найти";
        searchButton.UseVisualStyleBackColor = true;
        searchButton.Click += searchButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(searchButton);
        Controls.Add(searchResult);
        Controls.Add(stringSearch);
        Controls.Add(textBox);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox;
    private TextBox stringSearch;
    private Label searchResult;
    private Button searchButton;
}