using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync.Controller
{
    class BrowseFolderUserControlController : IBrowseFolderUserControlController
    {
        public void AttachView(IBrowseFolderUserControl view)
        {
            view.FolderSelected += view_FolderSelected;
        }

        void view_FolderSelected(IBrowseFolderUserControl sender, string folderPath)
        {
            string currentPath = folderPath;
            sender.folderPath = currentPath;
        }
    }
}
