using System;
using System.Collections;
using System.Collections.Generic;

namespace Ch13CardLib
{
    public class Cards : List<Card>, ICloneable
    {
        public void CopyTo(Cards targetCards)
        {
            for (int i = 0; i < this.Count; i++)
            {
                targetCards[i] = this[i];
            }
        }

        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }
    }
}
