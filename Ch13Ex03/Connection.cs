using System;
using System.Timers;
using static System.Console;
namespace Ch13Ex03
{
    //public delegate void MessageHandler(string messageText);
    public class Connection
    {
        public event EventHandler<MessageArrivedEventArgs> MessageArrived;
        public string Name { get; set; }
        private readonly Timer _pollTimer;

        public Connection()
        {
            _pollTimer = new Timer(100);
            _pollTimer.Elapsed += CheckForMessage;
        }

        public void Connect() => _pollTimer.Start();
        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            WriteLine("Checking for new messages.");
            if (new Random().Next(9) == 0 && MessageArrived != null)
            {
                MessageArrived(this, new MessageArrivedEventArgs("Hello Mami!"));
            }
        }
    }
}
