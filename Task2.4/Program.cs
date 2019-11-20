using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt").Where(f => HasDigit(f)).ToList();

            foreach (var file in textFiles)
            {
                try
                {
                    string[] fileNameParts = file.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine($"\"{fileNameParts[fileNameParts.Length - 1]}\":\n-------------");

                    using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
                    {
                        while (!sr.EndOfStream)
                        { 
                            Console.Write((char)sr.Read());
                            Thread.Sleep(50);
                        }
                    }

                    Console.Write("\n\n");
                    Thread.Sleep(3000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static bool HasDigit(string fileName)
        {
            string[] fileNameParts = fileName.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            return fileNameParts[fileNameParts.Length - 1].Any(c => char.IsDigit(c));
        }
    }
}
