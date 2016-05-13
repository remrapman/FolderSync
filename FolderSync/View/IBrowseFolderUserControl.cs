using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync
{
    public delegate void FolderSelectedEventHandler(IBrowseFolderUserControl sender, string folderPath);

    public interface IBrowseFolderUserControl
    {
        event FolderSelectedEventHandler FolderSelected;

        string folderPath { set; get; }
    }
}
