using System;
using System.IO;

namespace Fileproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            list<string> lines = new List
            foreach (string file in files)
            {
                Console.WriteLine(file);
                //get file objects
                var fileData = new FileInfo(file);
                Console.WriteLine(fileData);
                string fileName = fileData.Name;
                string FileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name: {fileName}; location: {FileDirectory}; Size: {fileSize}");
                string line = ($"File name: {fileName}; location: {FileDirectory}; Size: {fileSize}");
            }

        }
    }
}
