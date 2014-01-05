using System;

namespace FizzBuzz.UnitTests
{
    internal class AssertHelper
    {
        public static bool IsPositiveInteger(string s)
        {
            int result;
            if (!Int32.TryParse(s, out result))
            {
                return false;
            }
            return result > 0;
        }

        public static bool IsFizz(string s)
        {
            return s == "Fizz";
        }

        public static bool IsBuzz(string s)
        {
            return s == "Buzz";
        }

        public static bool IsFizzBuzz(string s)
        {
            return s == "FizzBuzz";
        }
    }
}