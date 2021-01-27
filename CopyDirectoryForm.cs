using System;
using System.Windows.Forms;

namespace CopyDirectory
{
    public partial class CopyDirectoryForm : Form
    {
        public CopyDirectoryForm()
        {
            InitializeComponent();
        }

        private void fromBrowse_Click(object sender, EventArgs e)
        {
            fromPath.Text = assignSelectedPath();
        }

        private void toBrowse_Click(object sender, EventArgs e)
        {
            toPath.Text = assignSelectedPath();
        }

        private string assignSelectedPath()
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                return diag.SelectedPath;  //selected folder path
            }
            return null;
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(toPath.Text) && !String.IsNullOrWhiteSpace(fromPath.Text))
            {
                CopyDirectory.Copy(fromPath.Text, toPath.Text, x => print(x));
            }
            else
            {
                print(" Please chosse a folder to copy from and to");
            }
        }

        public string print(string textToPrint)
        {
            copingInfoTextBox.Text += textToPrint + System.Environment.NewLine;
            copingInfoTextBox.Update();
            return copingInfoTextBox.Text;
        }
    }
}
