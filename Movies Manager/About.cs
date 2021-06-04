using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movies_Manager
{
    public partial class MnuAbout : Form
    {
        public MnuAbout()
        {
            InitializeComponent();
        }
        // This method to close the about us dailag box
        private void btnAboutClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // This method to select the text that we need to change its styling
        private void SelectRichText(RichTextBox rch, string target)
        {
            int pos = rch.Text.IndexOf(target);
            if (pos < 0)
            {
                // Not found. Select nothing.
                rch.Select(0, 0);
            }
            else
            {
                // Found the text. Select it.
                rch.Select(pos, target.Length);
            }
        }
        // A method to change the text styling in about us dialog box
        private void MnuAbout_Load(object sender, EventArgs e)
        {
            SelectRichText(richTextBox1, "Movie Manager Application");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 16);
            richTextBox1.SelectionColor = Color.Red;

            SelectRichText(richTextBox1, "Majed Alasemi");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold);
            
            SelectRichText(richTextBox1, "12/13/2020");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold);
            
            SelectRichText(richTextBox1, "1.0");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold);
        }
    }
}
