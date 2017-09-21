using System;

namespace Ch11CardLib
{
    public class Card : ICloneable
    {
        public readonly Rank rank;
        public readonly Suit suit;
        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;
        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Club;
        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower than deuces.
        /// </summary>
        public static bool isAceHigh = true;
        public static bool operator ==(Card card1, Card card2) => card1?.suit == card2?.suit && card1?.rank == card2?.rank;
        public static bool operator !=(Card card1, Card card2) => !(card1 == card2);
        public override bool Equals(object card) => this == (Card) card;
        public override int GetHashCode() => 13 * (int) suit + (int) rank;

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                        return card2.rank != Rank.Ace;
                    if (card2.rank == Rank.Ace)
                        return false;
                    return card1.rank > card2.rank;
                }
                return card1.rank > card2.rank;
            }
            if (useTrumps && card2.suit == trump)
            {
                return false;
            }
            return true;
        }

        public static bool operator <(Card card1, Card card2) => !(card1 >= card2);

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    if (card2.rank == Rank.Ace)
                    {
                        return false;
                    }
                    return card1.rank >= card2.rank;
                }
            }
            if (useTrumps && card2.suit == trump)
            {
                return false;
            }
            return true;
        }

        public static bool operator <=(Card card1, Card card2) => !(card1 >= card2);
        private Card()
        {
            
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString() => "The " + rank + " of " + suit + "s";
        public object Clone() => MemberwiseClone();
    }
}
