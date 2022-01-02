using System;
using System.Collections.Generic;

namespace MaxElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<String>(){"-1.23", "2.34", "-3.45", "4.56", "-5.67", "6.78", "-7.89", "8.9", "-9", "10.12"};
            Func<String, float> getParameter = ConvertStringToFloat;

            Console.WriteLine($"Максимальный элемент коллекции: {list.GetMax(getParameter)}");
        }

        static float ConvertStringToFloat(String str)
        {
            return Convert.ToSingle(str);
        }
    }
}
