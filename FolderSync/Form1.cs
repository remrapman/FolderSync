using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolderSync.Controller;



namespace FolderSync
{
    public partial class Form1 : Form
    {

        IFilterUserControlController FilterController;
        IBrowseFolderUserControlController FolderController;

        public Form1()
        {
            InitializeComponent();
            FilterController = new FilterUserControlController();
            //FilterController.AttachView(includeFilter);
            //FilterController.AttachView(excludeFilter);

            FolderController = new BrowseFolderUserControlController();
            //FolderController.AttachView(leftFolderUserControl);
            //FolderController.AttachView(rightFolderUserControl);


        }


        private void AnalizeButton_Click(object sender, EventArgs e)
        {
            // LeftListBox
            //AddDifferenceToListBox();

            //RightListBox
            //AddDifferenceToListBox();
        }   
            private void AddDifferenceToListBox(string a, string b, ListBox myListBox)
            {
            CompareFolders analize = new CompareFolders(a, b);
            List<string> DirList = analize.Compare();
            myListBox.DataSource = null;
            myListBox.DataSource = DirList;
            }

            private void SyncFolderButton_Click(object sender, EventArgs e)
            {
                int direction = ActionTypesComboBox.SelectedIndex;

                DoSync sync = new DoSync();
                sync.Sync();
            }
        }

    }


