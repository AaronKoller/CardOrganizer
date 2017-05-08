using System;
using System.Collections.Generic;
using System.Linq;
using CardOrganizer.Interfaces;

namespace CardOrganizer
{
    public class Deck : IDeck
    {
        private List<ICard> _deck;
        private readonly ICard _card;
        private readonly Random _random = new Random();

        public List<ICard> Cards => _deck;

        public Deck()
        {
        }

        public Deck(ICard card)
        {
            _card = card;
            _deck = new List<ICard>();
            Create();
        }

        /// <summary>
        /// Creates / recreates a new list of ordered cards.
        /// </summary>
        public virtual List<ICard> Create() {

            //ensures that we always have a new deck of the proper length
            _deck = new List<ICard>();

            foreach (int valueSuit in _card.ValueSuits)
            {
                foreach (int valueName in _card.ValueNames)
                {
                    _deck.Add(_card.Create(valueSuit, valueName));
                }
            }
            return _deck;
        }
        
        /// <summary>
        ///     Sort a deck of cards.
        /// </summary>
        public virtual List<ICard> Sort()
        {
            return _deck = Cards.OrderBy(a => a.ValueSuit).ThenBy(b => b.ValueName).ToList();
        }

        /// <summary>
        ///     Shuffles the deck of cards.
        /// </summary>
        public virtual List<ICard> Shuffle()
        {
            for (var i = 0; i < Cards.Count; i++)
            {
                Swap(_deck, i, _random.Next(i, Cards.Count));
            }
            return _deck;
        }

        /// <summary>
        ///     Swaps one item in a list with another.
        /// </summary>
        /// <param name="_cards">list of cards to swap and element position</param>
        /// <param name="i">Initial item</param>
        /// <param name="j">Swapped location</param>
        public void Swap(List<ICard> cards, int i, int j)
        {
            var tempItem = cards[i];
            cards[i] = cards[j];
            cards[j] = tempItem;
        }
    }
}