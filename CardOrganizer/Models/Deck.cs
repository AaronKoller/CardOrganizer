using System;
using System.Collections.Generic;
using System.Linq;
using CardOrganizer.Interfaces;

namespace CardOrganizer
{
    public class Deck : IDeck
    {
        private readonly List<ICard> _deck;
        private readonly ICard _card;
        private readonly Random _random = new Random();
        public List<ICard> Cards { get; private set; }

        public Deck(ICard card)
        {
            _card = card;
            _deck = new List<ICard>();
            Create();
        }

        /// <summary>
        /// Creates a new list of ordered cards
        /// </summary>
        public List<ICard> Create()
        {
            foreach (int valueSuit in _card.ValueSuits)
            {
                foreach (int valueName in _card.ValueNames)
                {
                    _deck.Add(_card.Create(valueSuit, valueName));
                }
            }
            return Cards = _deck;
        }
        
        /// <summary>
        ///     Sort a deck of cards
        /// </summary>
        public List<ICard> Sort()
        {
            return Cards = Cards.OrderBy(a => a.ValueSuit).ThenBy(b => b.ValueName).ToList();
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
            return Cards;
        }

        /// <summary>
        ///     Swaps one item in a list with another.
        /// </summary>
        /// <param name="_cards">list of cards to swap and element position</param>
        /// <param name="i">Initial item</param>
        /// <param name="j">Swapped location</param>
        private void Swap(List<ICard> cards, int i, int j)
        {
            var tempItem = cards[i];
            cards[i] = cards[j];
            cards[j] = tempItem;
        }
    }
}