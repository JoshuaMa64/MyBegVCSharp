using static System.Console;
using Ch11CardLib;

namespace Ch11CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Card.isAceHigh = true;
            WriteLine("Aces are high.");
            Card.useTrumps = true;
            Card.trump = Suit.Club;
            WriteLine("Clubs are trumps.");
            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club, Rank.Five);
            card2 = new Card(Suit.Club, Rank.Five);
            card3 = new Card(Suit.Club, Rank.Ace);
            card4 = new Card(Suit.Heart, Rank.Ten);
            card5 = new Card(Suit.Diamond, Rank.Ace);
            WriteLine($"{card1} == {card2} ? {card1 == card2}");
            WriteLine($"{card1} != {card3} ? {card1 != card3}");
            WriteLine($"{card1}.Equals({card4}) ? {card1.Equals(card4)}");
            ReadKey();
        }
    }
}
