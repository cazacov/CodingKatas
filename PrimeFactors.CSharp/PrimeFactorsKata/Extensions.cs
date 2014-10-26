using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class Extensions
    {
        public static List<int> ToList(this PrimeSet set)
        {
            var result = new List<int>();

            set.ForEach(result.Add);
            return result;
        }

    }
}
