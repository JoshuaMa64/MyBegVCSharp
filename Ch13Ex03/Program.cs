using System.Threading;
using static System.Console;

namespace Ch13Ex03
{
    class Program
    {
        static void Main()
        {
            Connection myConnection1 = new Connection { Name = "First connection."  };
            Connection myConnection2 = new Connection { Name = "Second connection." };
            Display myDisplay = new Display();
            myConnection1.MessageArrived += myDisplay.DisplayMessage;
            myConnection2.MessageArrived += myDisplay.DisplayMessage;
            myConnection1.Connect();
            myConnection2.Connect();
            Thread.Sleep(200);
            ReadKey();
        }
    }
}
