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
                    using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
                    {
                        while (!sr.EndOfStream)
                        { 
                            Console.Write((char)sr.Read());
                            Thread.Sleep(50);
                        }
                    }

                    Console.WriteLine();
                    Thread.Sleep(3000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }

        private static bool HasDigit(string fileName)
        {
            const string digits = "0123456789";

            foreach(char digit in digits)
                if (fileName.Contains(digit))
                    return true;

            return false;
        }
    }
}
