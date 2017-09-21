using static System.Console;
namespace Ch13Ex03
{
    public class Display
    {
        public void DisplayMessage(object source, MessageArrivedEventArgs e)
        {
            WriteLine($"Message arrived from: {((Connection)source).Name}");
            WriteLine($"Message Text: {e.Message}");
        }
    }
}