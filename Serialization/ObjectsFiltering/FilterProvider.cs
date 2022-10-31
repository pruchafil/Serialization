using Serialization.SaveSystem;
using System;
using System.Text.RegularExpressions;

namespace Serialization.ObjectsFiltering
{
    public static class FilterProvider
    {
        public static string[] FilterSplit(String term)
        {
            var formatted = DataLoader.Self.Data.ToFormattedString();
            var formattedLower = formatted.ToLower();

            string[] results = Regex.Split(formatted, term);

            return results;
        }
    }
}