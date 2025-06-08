using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameEngine;

namespace GameEngine.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Card_InitializesWithValueAndProperties()
        {
            // Arrange
            var properties = CardProperty.Shield | CardProperty.Poison;

            // Act
            var card = new Card
            {
                Value = 7,
                Properties = properties
            };

            // Assert
            Assert.AreEqual(7, card.Value);
            Assert.IsTrue(card.Properties.HasFlag(CardProperty.Shield));
            Assert.IsTrue(card.Properties.HasFlag(CardProperty.Poison));
            Assert.IsFalse(card.Properties.HasFlag(CardProperty.Stealth));
        }
    }
}