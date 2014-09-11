using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Tests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandShouldNotBeNull()
        {
            Hand hand = new Hand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandShouldHaveCards()
        {
            Hand hand = new Hand(new List<ICard>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandShouldNotHaveNullCards()
        {
            Hand hand = new Hand(
                new List<ICard>()
                {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Hearts),
                    null
                });
        }

        [TestMethod]
        public void HandToStringShouldBeCorrect()
        {
            var card1 = new Card(CardFace.Two, CardSuit.Clubs);
            var card2 = new Card(CardFace.Five, CardSuit.Spades);
            var card3 = new Card(CardFace.Jack, CardSuit.Hearts);
            var card4 = new Card(CardFace.Six, CardSuit.Diamonds);

            Hand hand = new Hand(
                new List<ICard>()
                {
                    card1,
                    card2,
                    card3,
                    card4
                });

            var expected = new StringBuilder();
            expected.AppendLine(card1.ToString());
            expected.AppendLine(card2.ToString());
            expected.AppendLine(card3.ToString());
            expected.AppendLine(card4.ToString());

            Assert.AreEqual(expected.ToString(), hand.ToString());
        }
    }
}
