using System;
using System.Collections.Generic;
using System.IO;

namespace GetPathDirectoryApplication
{
    public class PathApplication
    {
        public void GetPath(){

            List<string> ListExampleGetPath = new List<string>();

            ListExampleGetPath.Add(AppDomain.CurrentDomain.BaseDirectory);
            ListExampleGetPath.Add(Environment.CurrentDirectory);
            ListExampleGetPath.Add(Directory.GetCurrentDirectory());
            ListExampleGetPath.Add(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);

            foreach(string path in ListExampleGetPath){
                Console.WriteLine(path);
            }
        }
    }
}