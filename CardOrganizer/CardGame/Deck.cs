using System;
using System.Collections.Generic;
using System.Linq;
using CardOrganizer.Interfaces;

namespace CardOrganizer.CardGame
{
    public class Deck : IDeck
    {
        private readonly ICard _card;
        private readonly Random _random = new Random();

        public List<ICard> Cards { get; private set; }

        public Deck()
        {
        }

        public Deck(ICard card)
        {
            _card = card;
            Cards = new List<ICard>();
            Create();
        }

        /// <summary>
        /// Creates / recreates a new list of ordered cards.
        /// </summary>
        public List<ICard> Create() {

            //ensures that we always have a new deck of the proper length
            Cards = new List<ICard>();

            foreach (int valueSuit in _card.ValueSuits)
            {
                foreach (int valueName in _card.ValueNames)
                {
                    Cards.Add(_card.Create(valueSuit, valueName));
                }
            }
            return Cards;
        }
        
        /// <summary>
        ///     Sort a deck of cards.
        /// </summary>
        public virtual List<ICard> Sort()
        {
            return Cards = Cards.OrderBy(a => a.NumericSuit).ThenBy(b => b.NumericName).ToList();
        }

        /// <summary>
        ///     Shuffles the deck of cards.
        /// </summary>
        public virtual List<ICard> Shuffle()
        {
            for (var i = 0; i < Cards.Count; i++)
            {
                Swap(Cards, i, _random.Next(i, Cards.Count));
            }
            return Cards;
        }

        /// <summary>
        ///     Swaps one item in a list with another.
        /// </summary>
        /// <param name="cards">list of cards to swap and element position</param>
        /// <param name="i">Initial item</param>
        /// <param name="j">Swapped location</param>
        public void Swap(List<ICard> cards, int i, int j)
        {
            var tempItem = cards[i];
            cards[i] = cards[j];
            cards[j] = tempItem;
        }

        /// <summary>
        ///     Prints all the cards in a deck.
        /// </summary>
        public void PrintCards()
        {
            Cards.ForEach(c => Console.WriteLine(c.Name + " of " + c.Suit));
        }
    }
}