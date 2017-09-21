using static System.Console;
namespace Ch13Ex02
{
    public static class Display
    {
        public static void DisplayMessage(string message)
            => WriteLine($"Message arrived: {message}");
    }
}