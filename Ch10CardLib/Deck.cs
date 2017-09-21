using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
// ReSharper disable All

namespace Ch10CardLib
{
    public class Deck
    {
        private readonly Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 0; rankVal < 13; rankVal++)
                {
                    cards[suitVal * 13 + rankVal] = new Card((Suit) suitVal, (Rank) rankVal);
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            throw new ArgumentOutOfRangeException(nameof(cardNum), cardNum,
                "Value must be between 0 and 51");
        }

        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(52);
                    if (assigned[destCard] == false)
                        foundCard = true;
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }
    }
}
