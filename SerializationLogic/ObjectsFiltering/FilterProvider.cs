using Serialization.SaveSystem;
using System;

namespace Serialization.ObjectsFiltering
{
    public static class FilterProvider
    {
        public static (int, string) FilterFind(String term)
        {
            var formatted = DataLoader.Self.Data.ToFormattedString();
            var formattedLower = DataLoader.Self.Data.ToFormattedString().ToLower();
            int index     = formattedLower.IndexOf(term.ToLower());

            return index == -1 ? (-1, null) : (index, formatted);
        }
    }
}