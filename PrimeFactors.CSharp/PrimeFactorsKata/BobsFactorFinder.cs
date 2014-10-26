using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata
{
    public class BobsFactorFinder : IFactorFinder
    {
        public PrimeSet FindFactors(long n)
        {
            PrimeSet result = new Empty();

            for (long candidate = 2; n > 1; candidate++)
                for (; n % candidate == 0; n /= candidate)
                    result = result.Add(candidate);
            return result;
        }
    }
}
