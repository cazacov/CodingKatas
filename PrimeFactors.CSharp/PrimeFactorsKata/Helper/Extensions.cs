using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class Extensions
    {
        public static List<long> ToList(this PrimeSet set)
        {
            var result = new List<long>();

            set.ForEach(result.Add);
            return result;
        }

    }
}
