using System.Collections.Generic;

namespace CardOrganizer.Interfaces
{
    public interface IDeck
    {
        List<ICard> Create();

        List<ICard> Shuffle();

        List<ICard> Sort();
    }
}