using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightweight_Gallery
{
    public partial class Main : Form
    {
        private string selectedFolder;
        public Main()
        {
            InitializeComponent();
        }

        public void OpenFolder(string _selectedFolder)
        {
            selectedFolder = _selectedFolder;
            folderSelection1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void folderSelection1_Load(object sender, EventArgs e)
        {
                
        }
    }
}
