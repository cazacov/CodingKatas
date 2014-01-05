using System;
using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private readonly IResultPrinter printer;

        public FizzBuzzGame(IResultPrinter printer)
        {
            this.printer = printer;
        }

        public void PlayTheGame()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (IsMultipleOfThree(i) && IsMultipleOfFive(i))
                {
                    printer.Print("FizzBuzz");
                } 
                else if (IsMultipleOfThree(i))
                {
                    printer.Print("Fizz");
                }
                else if (IsMultipleOfFive(i))
                {
                    printer.Print("Buzz");
                }
                else
                {
                    printer.Print(i.ToString(CultureInfo.InvariantCulture));
                }
            }
        }

        private static bool IsMultipleOfFive(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsMultipleOfThree(int i)
        {
            return i  %3 == 0;
        }
    }
}
