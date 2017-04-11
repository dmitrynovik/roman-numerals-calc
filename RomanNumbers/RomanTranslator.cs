using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumbers
{
    public static class RomanTranslator
    {
        private static readonly int[] DigitsInOrder;
         
        static readonly IDictionary<int, char> CharMap = new SortedDictionary<int, char>()
        {
            {1, 'I'},
            {5, 'V'},
            {10, 'X'},
            {50, 'L'},
            {100, 'C'},
            {500, 'D'},
            {1000, 'M'},
        };

        static RomanTranslator()
        {
            DigitsInOrder = CharMap.Keys.OrderByDescending(x => x).ToArray();
        }

        public static string ToRomans(this int num)
        {
            const int maxValue = 3000;

            if (num < 0) throw new ArgumentException("Please insert positive number", nameof(num));
            if (num > maxValue) throw new ArgumentException("Please insert value between 0 and 3000", nameof(num));

            var buf = new StringBuilder();

            while (num > 0)
            {
                foreach (var d in DigitsInOrder)
                {
                    var result = num - d;
                    if (result >= 0)
                    {
                        buf.Append(CharMap[d]);
                        num -= d;
                        break;
                    }
                }
            }
            return buf
                .Replace("VIIII", "IX")
                .Replace("IIII", "IV")
                .Replace("LXXXX", "XC")
                .Replace("XXXX", "XL")
                .Replace("DCCCC", "CM")
                .Replace("CCCC", "CD")
                .ToString();
        }
    }
}
