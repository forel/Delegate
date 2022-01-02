using System;
using System.Collections;

namespace MaxElementFinder
{
    static class GetMaxElement
    {
        public static T GetMax<T>(this IEnumerable e, Func<T, float> getValue) where T : class
        {
            var elements = e.GetEnumerator();
            elements.MoveNext();

            var maxElement = (T)elements.Current;
            var maxValue = getValue(maxElement);

            while (elements.MoveNext())
            {
                if (maxValue < getValue((T)elements.Current))
                {
                    maxElement = (T)elements.Current;
                    maxValue = getValue(maxElement);
                }
            }

            return maxElement;
        }
    }
}
