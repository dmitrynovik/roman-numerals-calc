using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public static class RomanTranslator
    {
        private static int[] _digitsInOrder = {1000, 500, 100, 50, 10, 5, 1};
         
        static IDictionary<int, char> _charMap = new SortedDictionary<int, char>()
        {
            {1, 'I'},
            {5, 'V'},
            {10, 'X'},
            {50, 'L'},
            {100, 'C'},
            {500, 'D'},
            {1000, 'M'},
        };

        public static string ToRomans(this int num)
        {
            const int maxValue = 3000;

            if (num < 0) throw new ArgumentException("Please insert positive number", nameof(num));
            if (num > maxValue) throw new ArgumentException("Please insert value between 0 and 3000", nameof(num));

            var buf = new StringBuilder();

            while (num > 0)
            {
                foreach (var d in _digitsInOrder)
                {
                    var result = num/d;
                    if (result > 0)
                    {
                        buf.Append(ToRomans(result));
                        num -= result*d;
                        break;
                    }
                }
            }
            return buf.ToString();
        }
    }
}
