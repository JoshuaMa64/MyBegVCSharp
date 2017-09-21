using System;

namespace Ch13Ex03
{
    public class MessageArrivedEventArgs : EventArgs
    {
        public string Message { get; }

        public MessageArrivedEventArgs()
        {
            Message = "No message sent.";
        }

        public MessageArrivedEventArgs(string newMessage)
        {
            Message = newMessage;
        }
    }
}