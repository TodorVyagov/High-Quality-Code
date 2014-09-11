using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int DefaultCardCount = 5;

        public bool IsValidHand(IHand hand)
        {

            if (hand.Cards.Count != DefaultCardCount)
            {
                return false;
            }

            for (int i = 0; i < DefaultCardCount; i++)
            {
                for (int j = i; j < DefaultCardCount; j++)
                {
                    // have to compare their properties because CompareTo method is not implemented
                    if (hand.Cards[i].Face == hand.Cards[j].Face &&
                        hand.Cards[i].Suit == hand.Cards[j].Suit &&
                        (i != j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsFlush(IHand hand)
        {
            //A flush is a poker hand such as Q♣ 10♣ 7♣ 6♣ 4♣, where all five cards are of the same suit, but not in sequence. 
            // The hand must be valid, so we will not make this check

            for (int i = 0; i < DefaultCardCount - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int count = 1;
            if (hand.Cards[0].Face == hand.Cards[DefaultCardCount - 1].Face)
            {
                count++;
            }

            for (int i = 0; i < DefaultCardCount - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    count++;
                }
            }

            if (count == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
