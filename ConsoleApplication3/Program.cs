using System;
using System.IO;
using System.Text;

namespace ConsoleApplication3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var byteData = new byte[200];
            var charData = new char[200];
            try
            {
                var aFile = new FileStream("../../Program.cs", FileMode.Open);
                aFile.Seek(58, SeekOrigin.Begin);
                aFile.Read(byteData, 0, 200);
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }
            var d = Encoding.UTF8.GetDecoder();
            d.GetChars(byteData, 0, byteData.Length, charData, 0);
            Console.WriteLine(charData);
            Console.ReadKey();
        }
    }
}
