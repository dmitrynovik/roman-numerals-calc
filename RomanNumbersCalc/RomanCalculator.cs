using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumbersCalc
{
    public static class RomanCalculator
    {
        private static readonly int[] DigitsInOrder;
        private static readonly IDictionary<char, int> InverseMap;

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

        static RomanCalculator()
        {
            DigitsInOrder = CharMap.Keys.OrderByDescending(x => x).ToArray();
            InverseMap = CharMap.ToDictionary(x => x.Value, x => x.Key);
        }

        public static string AddRoman(this string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(s1));
            if (string.IsNullOrWhiteSpace(s2)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(s2));

            int num1 = ParseRoman(s1);
            int num2 = ParseRoman(s2);

            const int maxValue = 3000;
            if (num1 < 0) throw new ArgumentException("Please insert positive number", nameof(num1));
            if (num1 > maxValue) throw new ArgumentException("Please insert value between 0 and 3000", nameof(num1));
            if (num2 < 0) throw new ArgumentException("Please insert positive number", nameof(num2));
            if (num2 > maxValue) throw new ArgumentException("Please insert value between 0 and 3000", nameof(num2));

            var sum = num1 + num2;
            return ToRoman(sum);
        }

        private static int ParseRoman(string roman)
        {
            roman = roman?.Replace("IX", "VIIII")
                .Replace("IV", "IIII")
                .Replace("XC", "LXXXX")
                .Replace("XL", "XXXX")
                .Replace("CM", "DCCCC")
                .Replace("CD", "CCCC");

            if (roman == null)
                return 0;

            int cum = 0;
            foreach (var ch in roman)
            {
                cum += InverseMap[ch];
            }
            return cum;
        }

        private static string ToRoman(this int num)
        {
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
