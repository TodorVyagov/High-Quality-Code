using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardSiutShouldBeCorrectlyAssigned()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Diamonds);

            Assert.AreEqual(CardSuit.Diamonds, card.Suit);
        }

        [TestMethod]
        public void CardFaceShouldBeCorrectlyAssigned()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Hearts);
            
            Assert.AreEqual(CardFace.Ten, card.Face);
        }

        [TestMethod]
        public void CardToStringShouldBeCorrect()
        {
            Card card = new Card(CardFace.King, CardSuit.Spades);
            string expected = "King of Spades";

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
