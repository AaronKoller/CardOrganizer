using System;
using CardOrganizer.Interfaces;

namespace CardOrganizer.CardGame
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
            Console.WriteLine("====Shuffled Cards====");
            _deck.PrintCards();
            _deck.Sort();
            Console.WriteLine("====Sorted Cards====");
            _deck.PrintCards();
        }
    }
}