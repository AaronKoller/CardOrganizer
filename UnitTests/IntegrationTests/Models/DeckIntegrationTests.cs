using System;
using CardOrganizer;
using CardOrganizer.Interfaces;
using CardOrganizer.Models;
using NUnit.Framework;

namespace Tests.IntegrationTests.Models
{
    class DeckIntegrationTests
    {
        private ICard _card;
        private IDeck _deck;
        private IDeck _deck2;
        private readonly Random _random = new Random();
        
        [SetUp]
        public void Setup()
        {
            _card = new CardClassic();
            _deck = new Deck(_card);
            _deck2 = new Deck(_card);
        }

        [Test]
        public void Create_multipleCreates_returnsSingleInstanceOfCards()
        {
            //Arrange
            int countOfCardsBefore =  _deck.Cards.Count;

            //Act
            _deck.Create();
            int countOfCardsAfter = _deck.Cards.Count;

            //Assert
            Assert.AreEqual(countOfCardsBefore, countOfCardsAfter);
        }

        [Test]
        public void Sort_Shuffled_returnsSortedCards()
        {
            //Arrange
            _deck.Shuffle();

            //Act
            _deck.Sort();

            //Assert
            for (int i = 0; i < _deck.Cards.Count; i++)
            {
                Assert.AreEqual(_deck.Cards[i].ValueName, _deck2.Cards[i].ValueName);
                Assert.AreEqual(_deck.Cards[i].ValueSuit, _deck2.Cards[i].ValueSuit);
            }
        }

        [Test]
        public void Swap_RandomIndexes_ReturnsSwappedIndexes()
        {
            //Arrange
            int randomIntA = _random.Next(0, _deck.Cards.Count);
            int randomIntB = _random.Next(0, _deck.Cards.Count);

            var initialCardA = _deck.Cards[randomIntA];
            var initialCardB = _deck.Cards[randomIntB];

            //Act
            _deck.Swap(_deck.Cards, randomIntA, randomIntB);

            //Assert
            Assert.AreEqual(_deck.Cards.IndexOf(initialCardA), randomIntB);
            Assert.AreEqual(_deck.Cards.IndexOf(initialCardB), randomIntA);
        }
    }
}
