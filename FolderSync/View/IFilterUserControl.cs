using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync
{
    public delegate void FilterItemAddedEventHandler(IFilterUserControl sender, string newFilterItem);
    
    public interface IFilterUserControl
    {
        event FilterItemAddedEventHandler ItemAdded;

        List<string> FilterItems { set; get; }
        string newFilterItem { set; get; }


    }
}
