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

    //IFormInterface sender, string newFilterItem

    public partial class FiltersUserControl : UserControl, IFilterUserControl
    {
        private string filterItem = String.Empty;
        List<string> filterList;

        public FiltersUserControl()
        {
            InitializeComponent();
        }


        public event FilterItemAddedEventHandler ItemAdded;

        public List<string> FilterItems
        {
            get
            {
                return filterList;
            }

            set
            {
                filterList = value;
                filterListBox.DataSource = null;
                filterListBox.DataSource = filterList;

            }
        }

        public string newFilterItem
        {
            get
            {
                return filterItem;
            }

            set
            {
                filterItem = value;
            }
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            IsItemAdded();
        }

        private void IsItemAdded()
        {
            if (ItemAdded != null)
            {
                ItemAdded(this, itemAddedToFilterTextBox.Text);
            }
            //else
            //{
            //    List<string> FilterItems = new List<string>();
            //    FilterItems.Add(itemAddedToFilterTextBox.Text);
            //}
        }

        private void newFilterItemTextBox_TextChanged(object sender, EventArgs e)
        {
            addNewItemButton.Enabled = !String.IsNullOrEmpty(itemAddedToFilterTextBox.Text);
        }

    }
}
