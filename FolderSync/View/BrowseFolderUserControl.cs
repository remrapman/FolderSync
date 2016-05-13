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
    public partial class BrowseFolderUserControl : UserControl, IBrowseFolderUserControl
    {
        private string dirPath = String.Empty;
 
        public BrowseFolderUserControl()
        {
            InitializeComponent();
        }



        public event FolderSelectedEventHandler FolderSelected;

        public string folderPath
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private void browseFolderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
