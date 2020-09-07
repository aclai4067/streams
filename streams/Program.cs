using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "people.txt");
            var fileContents = ReadFile(fileName);
            Console.WriteLine(fileContents);

            // --- get file list ---
            //var files = directory.GetFiles("*.txt");
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file.Name);
            //}

            // --- return line1 from file ---
            //var file = new FileInfo(fileName);
            //if (file.Exists)
            //{
            //    using (var reader = new StreamReader(file.FullName))
            //    {
            //        Console.SetIn(reader);
            //        Console.WriteLine(Console.ReadLine());
            //    }
            //}
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
