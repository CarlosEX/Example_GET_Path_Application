using System;
using System.IO;

namespace GetPathDirectoryApplication
{
    public class PathApplication
    {
        public void GetPath(){
            string path1 = AppDomain.CurrentDomain.BaseDirectory;
            string path2 = Environment.CurrentDirectory;
            string path3 = Directory.GetCurrentDirectory();
            string path4 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            Console.WriteLine(path1);
            Console.WriteLine(path2);
            Console.WriteLine(path3);
            Console.WriteLine(path4);

        }
    }
}