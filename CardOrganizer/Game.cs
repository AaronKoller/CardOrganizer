using CardOrganizer.Interfaces;

namespace CardOrganizer
{
    public class Game : IGame
    {
        private readonly IDeck _deck;

        public Game(IDeck deck)
        {
            _deck = deck;
        }

        /// <summary>
        /// Starts the game.
        /// </summary>
        public void Start()
        {
            _deck.Shuffle();
            _deck.Sort();
        }
    }
}