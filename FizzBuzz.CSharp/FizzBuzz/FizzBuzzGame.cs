using System;
using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public IEnumerable<string> PlayTheGame()
        {
            var result = new List<String>();
            for (var i = 1; i <= 100; i++)
            {
                if (IsMultipleOfThree(i) && IsMultipleOfFive(i))
                {
                    result.Add("FizzBuzz");
                } else if (IsMultipleOfThree(i))
                {
                    result.Add("Fizz");
                }
                else if (IsMultipleOfFive(i))
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString(CultureInfo.InvariantCulture));
                }
            }
            return result;

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
