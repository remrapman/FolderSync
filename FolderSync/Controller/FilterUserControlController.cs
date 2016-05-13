using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync.Controller
{
    public class FilterUserControlController : IFilterUserControlController
    {

        public void AttachView(IFilterUserControl view)
        {
            view.ItemAdded += view_ItemAdded;
        }

        void view_ItemAdded(IFilterUserControl sender, string newFilterItem)
        {
            List<string> currentItems = sender.FilterItems;
            currentItems.Add(newFilterItem);

            sender.FilterItems = currentItems;
        }
    }
}
