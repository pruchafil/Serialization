using Serialization.SaveSystem;
using System;

namespace Serialization.ObjectsFiltering
{
    public static class FilterProvider
    {
        public static (int, string) FilterFind(String term)
        {
            var formatted = DataLoader.Self.Data.ToFormattedString();
            int index     = formatted.IndexOf(term.Trim());

            return index == -1 ? (-1, null) : (index, formatted);
        }
    }
}