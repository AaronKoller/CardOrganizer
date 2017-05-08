using System.Collections.Generic;
using CardOrganizer;
using CardOrganizer.Interfaces;
using Moq;
using NUnit.Framework;

namespace Tests.UnitTests.Models
{
    class DeckUnitTests
    {
        private Mock<ICard> _card;
        private IDeck _deck;

        [SetUp]
        public void Setup()
        {
            _card = new Mock<ICard>();
            _deck = new Deck(_card.Object);
        }

        [Test]
        public void Create_intArrays_returnsMultipleOfLengthsOfArrays()
        {
            //Arrange
            var suits = new List<int> {1, 2};
            var names = new List<int> {1, 2, 3};
            _card.Setup(c => c.ValueSuits).Returns(suits);
            _card.Setup(c => c.ValueNames).Returns(names);

            //Act
            var result = _deck.Create();

            //Assert
            Assert.AreEqual(6, result.Count);
        }
    }
}
