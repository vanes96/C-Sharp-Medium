using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

                    //Console.WriteLine();
                    //Console.WriteLine("******считываем построчно********");
                    //using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
                    //{
                    //    string line;
                    //    while ((line = sr.ReadLine()) != null)
                    //    {
                    //        Console.WriteLine(line);
                    //    }
                    //}

                    Console.WriteLine();
                    Console.WriteLine("******считываем блоками********");
                    using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
                    {
                        char[] array = new char[4];
                        // считываем 4 символа
                        sr.Read(array, 0, 4);

                        Console.WriteLine(array);
                    }
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            
        }

        static bool HasDigit(string fileName)
        {
            const string digits = "0123456789";

            foreach(char digit in digits)
                if (fileName.Contains(digit))
                    return true;

            return false;
        }
    }
}
