using System.Collections.Generic;

namespace MyFramework.Factories
{
    public static class DictionaryExtensions
    {
        public static Pair<T, U>[] ToPairs<T, U>(this Dictionary<T, U> dictionary)
        {
            var arr = new Pair<T, U>[dictionary.Keys.Count];

            var i = 0;
            foreach (var key in dictionary.Keys)
            {
                arr[i] = new Pair<T, U>(key, dictionary[key]);
                i++;
            }

            return arr;
        }
    }
}