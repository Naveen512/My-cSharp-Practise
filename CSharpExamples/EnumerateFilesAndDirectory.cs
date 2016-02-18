using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpExamples
{
    public  class EnumerateFilesAndDirectory
    {

        //To enumerate a collection of FileInfo objects in all directories
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(@"E:\Release 5 jan 2016");

                foreach (var fileName in directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
                {
                    Console.WriteLine("{0}", fileName.FullName);
                }
                Console.ReadKey();
            }
            catch (UnauthorizedAccessException UAExc)
            {
                Console.WriteLine(UAExc.Message);
            }
            catch(PathTooLongException PTLExe)
            {
                Console.WriteLine(PTLExe.Message);
            }

        }
        /*To enumerate a collection of DirectoryInfo objects
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo directryInfo = new DirectoryInfo(@"E:\Release 5 jan 2016");

                var dirNameCollection = from dir in directryInfo.EnumerateDirectories("*", SearchOption.AllDirectories)
                                        select new
                                        {
                                            name = dir.FullName
                                        };
                foreach (var dirName in dirNameCollection)
                {
                    Console.WriteLine("{0}", dirName);
                }
                Console.WriteLine("{0} directories found", dirNameCollection.Count());
            }
            catch (UnauthorizedAccessException UAExcep)
            {
                Console.WriteLine(UAExcep.Message);
            }
            catch(PathTooLongException PTExcep)
            {
                Console.WriteLine(PTExcep.Message);
            }
        }*/

        /*To enumerate file names in a directory and subdirectories

        static void Main(string[] args)
        {
            try
            {
                var files = from file in Directory.EnumerateFiles(@"C:\Users\NAVEEN\Desktop\versioning list", "*.txt", SearchOption.AllDirectories)
                            from line in File.ReadLines(file)
                            select new
                            {
                                File = file,
                                Line = line
                            };

                foreach (var f in files)
                {
                    Console.WriteLine("{0}\t{1}",f.File,f.Line);
                }

                Console.WriteLine("{0} direcotries found",files.Count().ToString());
            }
            catch (UnauthorizedAccessException UAExec)
            {
                Console.WriteLine(UAExec.Message);
            }
            catch (PathTooLongException PTLExec)
            {
                Console.WriteLine(PTLExec.Message);
            }
        }*/



        /* To enumerate Directory Names
        static void Main(string[] args)
        {

            try
            {
                string dirPaht = @"E:\TV_Projects\TV_Offersites\trunk\src";

                List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPaht));
                foreach (string directory in dirs)
                {
                    Console.WriteLine("{0}", directory.Substring(directory.LastIndexOf("\\") + 1));
                }
                Console.WriteLine("{0} directories found", dirs.Count);
                Console.ReadLine();
            }
            catch (UnauthorizedAccessException UExec)
            {
                Console.WriteLine(UExec.Message);
            }
            catch(PathTooLongException PLExec)
            {
                Console.WriteLine(PLExec.Message);
            }
        }*/
    }
}
