using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteData;
            char[] charData;
            try
            {
                FileStream aFile = new FileStream("Temp.txt", FileMode.Create);
                charData = "My pink half of the drainpipe.".ToCharArray();
                byteData = new byte[charData.Length];
                Encoder e = Encoding.UTF8.GetEncoder();
                e.GetBytes(charData, 0, charData.Length, byteData, 0, true);
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byteData, 0, byteData.Length);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
