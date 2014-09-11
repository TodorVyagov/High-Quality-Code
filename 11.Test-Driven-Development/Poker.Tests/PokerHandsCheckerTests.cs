using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        private IPokerHandsChecker checker;

        [TestInitialize]
        public void InitializePokerHandsChecker()
        {
            this.checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void PokerHandShouldBeValid()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                     new Card(CardFace.Two, CardSuit.Clubs),
                     new Card(CardFace.Two, CardSuit.Spades),
                     new Card(CardFace.Two, CardSuit.Hearts),
                     new Card(CardFace.Two, CardSuit.Diamonds),
                     new Card(CardFace.Seven, CardSuit.Spades)
                });

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void PokerHandShouldNotBeValid()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                     new Card(CardFace.Queen, CardSuit.Spades),
                     new Card(CardFace.Two, CardSuit.Clubs),
                     new Card(CardFace.Queen, CardSuit.Spades),
                     new Card(CardFace.Two, CardSuit.Diamonds),
                     new Card(CardFace.Seven, CardSuit.Spades)
                });

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void PokerHandShouldHave5Cards()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                     new Card(CardFace.Two, CardSuit.Clubs),
                     new Card(CardFace.Queen, CardSuit.Spades),
                     new Card(CardFace.Two, CardSuit.Diamonds),
                     new Card(CardFace.Seven, CardSuit.Spades)
                });

            Assert.IsFalse(checker.IsValidHand(hand));
        }
                
        [TestMethod]
        public void PokerHandShouldBeFlush()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                     new Card(CardFace.Two, CardSuit.Spades),
                     new Card(CardFace.Queen, CardSuit.Spades),
                     new Card(CardFace.Ten, CardSuit.Spades),
                     new Card(CardFace.Seven, CardSuit.Spades),
                     new Card(CardFace.Ace, CardSuit.Spades)

                });

            if (!checker.IsValidHand(hand))
            {
                Assert.Fail("Hand must be valid!");
            }

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void PokerHandShouldNotBeFlush()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                     new Card(CardFace.Two, CardSuit.Spades),
                     new Card(CardFace.Three, CardSuit.Spades),
                     new Card(CardFace.Two, CardSuit.Diamonds),
                     new Card(CardFace.Seven, CardSuit.Spades),
                     new Card(CardFace.Ace, CardSuit.Spades)

                });

            if (!checker.IsValidHand(hand))
            {
                Assert.Fail("Hand must be valid!");
            }

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void PokerHandShouldBeFourOfAKind()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                     new Card(CardFace.Ace, CardSuit.Diamonds),
                     new Card(CardFace.Ace, CardSuit.Hearts),
                     new Card(CardFace.Ace, CardSuit.Clubs),
                     new Card(CardFace.Seven, CardSuit.Spades),
                     new Card(CardFace.Ace, CardSuit.Spades)

                });

            if (!checker.IsValidHand(hand))
            {
                Assert.Fail("Hand must be valid!");
            }

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void PokerHandShouldNotBeFourOfAKind()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                     new Card(CardFace.Two, CardSuit.Spades),
                     new Card(CardFace.Three, CardSuit.Spades),
                     new Card(CardFace.Two, CardSuit.Diamonds),
                     new Card(CardFace.Seven, CardSuit.Spades),
                     new Card(CardFace.Ace, CardSuit.Spades)

                });

            if (!checker.IsValidHand(hand))
            {
                Assert.Fail("Hand must be valid!");
            }

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }
    }
}
