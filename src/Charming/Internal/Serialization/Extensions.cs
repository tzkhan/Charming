namespace Charming.Serialization
{
    using System;
    using System.Collections.Generic;

    internal static class Extensions
    {
        public static bool TryGetValueForAssignableType<T>(this IDictionary<Type, T> dictionary, Type key, out T value)
        {
            value = default;

            foreach (var pair in dictionary)
            {
                if (pair.Key.IsAssignableFrom(key))
                {
                    value = pair.Value;
                    return true;
                }
            }

            return false;
        }

        public static bool TryGetValueForAssignableType<T>(this IDictionary<(Type, string), T> dictionary, (Type, string) key, out T value)
        {
            value = default;

            foreach (var pair in dictionary)
            {
                if (pair.Key.Item1.IsAssignableFrom(key.Item1) && pair.Key.Item2 == key.Item2)
                {
                    value = pair.Value;
                    return true;
                }
            }

            return false;
        }
    }
}
