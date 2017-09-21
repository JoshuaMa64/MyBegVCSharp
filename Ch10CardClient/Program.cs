using static System.Console;
using Ch11CardLib;

namespace Ch10CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                WriteLine(tempCard.ToString());
                //if (i!=51)
                //    Write(", ");
                //else
                //    WriteLine();
            }
            ReadKey();
        }
    }
}
