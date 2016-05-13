using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync
{

    public delegate void FoldersForDiffferenceSelectedEventHandler(IFolderDifference sender, string sourcePath, string destPath);

    public interface IFolderDifference
    {

        event FoldersForDiffferenceSelectedEventHandler FoldersForDiffferenceSelected;

        List<string> folderDifference { set; get; }
        string sourcePath { set; get; }
        string destPath { set; get; }
    }
}
