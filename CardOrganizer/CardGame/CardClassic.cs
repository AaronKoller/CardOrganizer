﻿using System;
using System.Collections.Generic;
using System.Linq;
using CardOrganizer.Interfaces;

namespace CardOrganizer.CardGame
{
    public class CardClassic : ICard
    {

        public CardClassic()
        {
        }

        public CardClassic(CardSuitClassic cardSuitClassic, CardNameClassic cardNameClassic)
        {
            CardSuit = cardSuitClassic;
            CardName = cardNameClassic;
        }

        private CardSuitClassic CardSuit { get; }
        private CardNameClassic CardName { get; }

        //returns the names of the suits a
        public string Suit => CardSuit.ToString();
        public string Name => CardName.ToString();
        
        //returns the int value this cards enumeration
        public int NumericSuit => (int) CardSuit;
        public int NumericName => (int) CardName;

        //returns IEnumerable of ints of from enumerations
        public IEnumerable<int> ValueSuits => ((int[])Enum.GetValues(typeof(CardSuitClassic))).ToList();
        public IEnumerable<int> ValueNames => ((int[])Enum.GetValues(typeof(CardNameClassic))).ToList();

        //allows deck to create a card based on its enumerated value
        public ICard Create(int suit, int name)
        {
            return new CardClassic((CardSuitClassic) suit, (CardNameClassic) name);
        }
    }

    public enum CardSuitClassic
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }

    public enum CardNameClassic
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }
}