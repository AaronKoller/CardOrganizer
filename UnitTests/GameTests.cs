using CardOrganizer;
using CardOrganizer.Models;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class GameTests
    {

        private Game _game;
        private Mock<CardClassic> _cardClassic;
        private Mock<Deck> _deck;


        [SetUp]
        public void Setup()
        {
            _cardClassic = new Mock<CardClassic>();
            _deck = new Mock<Deck>(_cardClassic.Object);
            _game = new Game(_cardClassic.Object);
        }


        [Test]
        public void OrganizeCards_CallsAllMethods_ReturnsExecutionOfMethods()
        { //Arrange

            //_deck.Setup(d => d.).Returns(_deck.Object);
            //Act
            _game.Start();
            
            //Assert
            _deck.Verify(cc => cc.Shuffle(), Times.Once);
        }
    }
}
