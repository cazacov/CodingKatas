using System;

namespace PrimeFactorsKata
{
    /// <summary>
    /// Cons List
    /// </summary>
    /// <remarks>
    /// See http://en.wikipedia.org/wiki/Cons
    /// </remarks>
    public abstract class PrimeSet
    {
        public abstract PrimeSet Add(long newValue);
        public abstract void ForEach(Action<long> action);
    }

    public class Empty : PrimeSet
    {
        public override PrimeSet Add(long newValue)
        {
            return new NonEmpty(newValue, this);
        }

        public override void ForEach(Action<long> action)
        {
            ;
        }
    }

    public class NonEmpty : PrimeSet
    {
        public NonEmpty(long newValue, PrimeSet set)  
        {
            this.Value = newValue;
            this.Tail = set;
        }

        public readonly long Value;
        public readonly PrimeSet Tail;

        public override PrimeSet Add(long newValue)
        {
            return new NonEmpty(newValue, this);
        }

        public override void ForEach(Action<long> action)
        {
            action(this.Value);
            this.Tail.ForEach(action);
        }
    }
}