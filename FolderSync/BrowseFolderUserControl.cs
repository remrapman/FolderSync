using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderSync
{
    public partial class BrowseFolderUserControl : UserControl
    {
        public BrowseFolderUserControl()
        {
            InitializeComponent();
        }

        private void browseFolderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                browseFolderTextBox.Text = fileDialog.FileName;
            }
        }
    }
}
