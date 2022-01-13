using System;
using System.Collections;

namespace MaxElementFinder
{
    static class GetMaxElement
    {
        public static T GetMax<T>(this IEnumerable e, Func<T, float> getValue) where T : class
        {
            //Проверка, что коллекция не null или не пустая
            if (e == null || e.GetEnumerator() == null)
            {
                throw new ArgumentNullException("e");
            }

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
