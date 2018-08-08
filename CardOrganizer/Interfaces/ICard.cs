using System.Collections.Generic;

namespace CardOrganizer.Interfaces
{
    public interface ICard
    {
        int NumericSuit { get; }

        int NumericName { get; }

        string Suit { get; }

        string Name { get; }
        
        IEnumerable<int> ValueSuits { get; }

        IEnumerable<int> ValueNames { get; }

        ICard Create(int suit, int name);
    }
}