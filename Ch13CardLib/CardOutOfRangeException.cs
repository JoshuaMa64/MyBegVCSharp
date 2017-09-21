using System;

namespace Ch13CardLib
{
    public class CardOutOfRangeException : Exception
    {
        public Cards DeckContents { get; }

        public CardOutOfRangeException(Cards sourceDeckContents) 
            : base("There are only 52 cards in the deck.")
        {
            DeckContents = sourceDeckContents;
        }
    }
}