using Serialization.SaveSystem;
using System.Collections.Generic;

namespace Serialization.ObjectsFiltering;

public static class FilterProvider
{
    public static void Filter(IEnumerable<char> term)
    {
        var formatted = DataLoader.Self.Data.ToFormattedString();
    }
}