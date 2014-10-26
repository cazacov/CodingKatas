namespace PrimeFactorsKata
{
    /// <summary>
    /// Code we wrote during the Coding dojo on 2014-10-22 at CAXPerts
    /// </summary>
    public class DojoFactorFinder : IFactorFinder
    {
        public PrimeSet FindFactors(long value)
        {
            if (value <= 1)
            {
                return new Empty();
            }
            
            var dividor = FindDivisor(2, value);
            return new NonEmpty(dividor, FindFactors(value / dividor));
        }

        private long FindDivisor(long candidate, long value)
        {
            if (value%candidate == 0) 
                return candidate;
            else if (candidate > value / candidate)  // search up to sqrt(value)
                return value;
            else
                return FindDivisor(candidate + 1, value);
        }
    }
}