using System.Timers;
using static System.Console;

namespace Ch13Ex01
{
    class Program
    {
        private static int counter = 0;

        private static string displayString =
            "This string will appear one letter at a time. ";
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(100);
            myTimer.Elapsed += WriteChar;
            myTimer.Start();
            System.Threading.Thread.Sleep(200);
            ReadKey();
        }

        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Write(displayString[counter++ % displayString.Length]);
        }
    }
}
