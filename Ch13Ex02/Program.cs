using static System.Console;

namespace Ch13Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            var myConnection = new Connection();
            myConnection.MessageArrived += Display.DisplayMessage;
            myConnection.Connect();
            ReadKey();
        }
    }
}
