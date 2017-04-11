using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumbers;

namespace RomanTranslator.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    var str = Console.ReadLine();
                    int num;
                    if (int.TryParse(str, out num))
                        Console.WriteLine(num.ToRomans());
                    else
                        PrintError();
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
