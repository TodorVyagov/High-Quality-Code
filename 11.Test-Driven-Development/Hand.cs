using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            ValidateHand(cards);
            this.Cards = cards;
        }

        private void ValidateHand(IList<ICard> cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException("Cards in hand cannot be null!");
            }

            if (cards.Count == 0)
            {
                throw new ArgumentNullException("Hand must contain at least one card!");
            }

            foreach (var card in cards)
            {
                if (card == null)
                {
                    throw new ArgumentNullException("Hand cannot contain card with null value!");
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var card in this.Cards)
            {
                result.AppendLine(card.ToString());
            }

            return result.ToString();
        }
    }
}
