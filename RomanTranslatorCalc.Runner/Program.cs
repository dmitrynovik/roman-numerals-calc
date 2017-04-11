using System;
using System.Linq;

namespace RomanNumbersCalc.Runner
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    var str = Console.ReadLine()?.Split('+')
                        .Where(s => !string.IsNullOrWhiteSpace(s))
                        .Select(s => s.Trim())
                        .ToArray();

                    if (str == null || str.Length < 2)
                        PrintError();
                    else
                    {
                        Console.WriteLine(str[0].AddRoman(str[1]));
                    }  
                }
                catch (Exception)
                {
                    PrintError();
                }
            }
        }

        static void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Expected input: 0 to 3000");
        }
    }
}
