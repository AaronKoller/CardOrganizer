using System;
using System.Linq;
using CardOrganizer.CardGame;
using NUnit.Framework;

namespace Tests.UnitTests.CardGame
{
    [TestFixture]
    class CardClassicTests
    {
        private CardClassic _cardClassic;

        [SetUp]
        public void Setup()
        {
            _cardClassic = new CardClassic();
        }

        [Test]
        public void CardClassic_NumberOfNameEnums_returnsSameCountAsValueNames()
        {
            //Arrange
            var valueNamesCount = _cardClassic.ValueNames.ToList().Count;

            //Act
            var nameEnumCount = ((int[])Enum.GetValues(typeof(CardNameClassic))).ToList().Count;

            //Assert
            Assert.AreEqual(valueNamesCount, nameEnumCount);
        }

        [Test]
        public void CardClassic_NumberOfSuitEnums_returnsSameCountAsSuitNames()
        {
            //Arrange
            var valueSuitCount = _cardClassic.ValueSuits.ToList().Count;

            //Act
            var suitEnumCount = ((int[])Enum.GetValues(typeof(CardSuitClassic))).ToList().Count;

            //Assert
            Assert.AreEqual(valueSuitCount, suitEnumCount);
        }
    }
}
