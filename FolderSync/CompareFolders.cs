using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSync
{
    public class CompareFolders
    {
        private string sourceFolderPath;
        private string destinationFolderPath;
        private List<string> differenceList;

        public CompareFolders(string sourceFolder, string destinationFolder)
        {
            sourceFolderPath = sourceFolder;
            destinationFolderPath = destinationFolder;
        }


        public List<string> Compare()
        {

            List<string> difList = new List<string>();

            System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(sourceFolderPath);
            System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(destinationFolderPath);

            // Take a snapshot of the file system.
            IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            //A custom file comparer defined below
            FileCompare myFileCompare = new FileCompare();

            // This query determines whether the two folders contain
            // identical file lists, based on the custom file comparer
            // that is defined in the FileCompare class.
            // The query executes immediately because it returns a bool.
            bool areIdentical = list1.SequenceEqual(list2, myFileCompare);

            if (areIdentical == true)
            {
                Console.WriteLine("the two folders are the same");
            }
            else
            {
                Console.WriteLine("The two folders are not the same");
            }

            // Find the set difference between the two folders.

            var queryList1Only = (from file in list1
                                  select file).Except(list2, myFileCompare);

            foreach (var v in queryList1Only)
            {
                difList.Add(v.FullName);
            }
            differenceList = difList;

            // For getting results:
            // Need create new list in needed class like => List<string> differenceList = myCompare.Compare();
            return differenceList;
        }
    }

    // Compare files by name and length
    class FileCompare : System.Collections.Generic.IEqualityComparer<System.IO.FileInfo>
    {
        public FileCompare() { }

        public bool Equals(System.IO.FileInfo f1, System.IO.FileInfo f2)
        {
            return (f1.Name == f2.Name &&
                    f1.Length == f2.Length);
        }

        // Return a hash that reflects the comparison criteria. According to the 
        // rules for IEqualityComparer<T>, if Equals is true, then the hash codes must
        // also be equal. Because equality as defined here is a simple value equality, not
        // reference identity, it is possible that two or more objects will produce the same
        // hash code.
        public int GetHashCode(System.IO.FileInfo fi)
        {
            string s = String.Format("{0}{1}", fi.Name, fi.Length);
            return s.GetHashCode();
        }
    }
}
    
