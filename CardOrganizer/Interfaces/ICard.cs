using System.Collections.Generic;

namespace CardOrganizer.Interfaces
{
    public interface ICard
    {
        int ValueSuit { get; }

        int ValueName { get; }

        IEnumerable<int> ValueSuits { get; }

        IEnumerable<int> ValueNames { get; }

        ICard Create(int suit, int name);
    }
}