using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lightweight_Gallery
{
    
    public partial class FolderSelection : UserControl
    {
        public Main form1;
        public FolderSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = diag.SelectedPath;
            }
            else
            { textBox1.Text = "You didn't select the folder!"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                form1.OpenFolder(textBox1.Text);
            }
            else
            {

            }
            
        }
    }
}
