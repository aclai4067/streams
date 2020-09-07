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
            var fileContents = ReadAcctLines(fileName);


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

            // --- read all file lines ---
            //var fileContents = ReadFile(fileName);
            //string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var line in fileLines)
            //{
            //    Console.WriteLine(line);
            //}
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<Account> ReadAcctLines(string fileName)
        {
            var accounts = new List<Account>();

            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while((line = reader.ReadLine()) != null)
                {
                    var acct = new Account();
                    string[] values = line.Split(',');
                    acct.FirstName = values[0];
                    acct.LastName = values[1];
                    acct.AccountNumber = values[2];
                    acct.PrimaryAddress = values[3];
                    acct.SecondaryAddress = values[4];
                    acct.City = values[5];
                    acct.State = values[6];
                    acct.Zip = values[7];
                    decimal amount;
                    if (decimal.TryParse(values[8], out amount))
                    {
                        acct.Charges = amount;
                    }
                    if (decimal.TryParse(values[9], out amount))
                    {
                        acct.Payments = amount;
                    }

                    accounts.Add(acct);
                }
            }

            return accounts;
        }
    }
}
