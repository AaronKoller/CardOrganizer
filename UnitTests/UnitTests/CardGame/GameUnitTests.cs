using CardOrganizer.CardGame;
using Moq;
using NUnit.Framework;

namespace Tests.UnitTests.CardGame
{
    [TestFixture]
    class GameUnitTests
    {
        private Game _game;
        private Mock<Deck> _deck;

        [SetUp]
        public void Setup()
        {
            _deck = new Mock<Deck>();
            _game = new Game(_deck.Object);
        }

        [Test]
        public void OrganizeCards_CallsAllMethods_ReturnsExecutionCountOnceOfMethods()
        { 
            //Arrange

            //Act
            _game.Start();

            //Assert
            _deck.Verify(cc => cc.Shuffle(), Times.Once);
            _deck.Verify(cc => cc.Sort(), Times.Once);
        }
    }
}
