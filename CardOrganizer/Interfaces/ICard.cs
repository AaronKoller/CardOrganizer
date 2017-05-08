using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CardOrganizer
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