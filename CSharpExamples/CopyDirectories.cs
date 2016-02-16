using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public  class CopyDirectories
    {
        static void Main()
        {
            CopyDirectory(@"E:\Compare", @"D:\destcompare", false);
        }

        public static void CopyDirectory(string sourceDirName,string destinDirName,bool copySubDir)
        {
            //Get full information of subDirectory
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("source of the directory doesn't exist or could not found" + sourceDirName);
            }

            DirectoryInfo[] dirInfo = dir.GetDirectories();

            // If destination directory doesn't exist create new one

            if(!Directory.Exists(destinDirName))
            {
                Directory.CreateDirectory(destinDirName);
            }

            // Get the files of directory and copy them to new location

            FileInfo[] fileInfo = dir.GetFiles();

            foreach (FileInfo file in fileInfo)
            {
                string tempPath = Path.Combine(destinDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            if (copySubDir)
            {
                foreach (DirectoryInfo sub in dirInfo)
                {
                    string tempPath = Path.Combine(destinDirName, sub.Name);
                    CopyDirectory(sub.FullName, tempPath, copySubDir);
                }
            }
        }
    }
}
