using System.Collections.Generic;

namespace CardOrganizer.Interfaces
{
    public interface IDeck
    {
        List<ICard> Create();

        List<ICard> Shuffle();

        List<ICard> Sort();

        List<ICard> Cards { get; }

        void PrintCards();

        void Swap(List<ICard> cards, int i, int j);
    }
}