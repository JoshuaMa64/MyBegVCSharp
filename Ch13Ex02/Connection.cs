﻿using System;
using System.Timers;
using static System.Console;
namespace Ch13Ex02
{
    public delegate void MessageHandler(string messageText);
    public class Connection
    {
        public event MessageHandler MessageArrived;
        private readonly Timer _pollTimer;

        public Connection()
        {
            _pollTimer = new Timer(100);
            _pollTimer.Elapsed += CheckForMessage;
            //_pollTimer.Elapsed += SendMessage;
        }

        public void Connect() => _pollTimer.Start();
        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            WriteLine("Checking for new messages.");
            if (new Random().Next(9) == 0 && MessageArrived != null)
            {
                MessageArrived("Hello Mami!");
            }
        }

        private static void SendMessage(object source, ElapsedEventArgs e) => WriteLine("GIT CHEAT SHEET");
    }
}
