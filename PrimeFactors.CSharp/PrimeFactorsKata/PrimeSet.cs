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
        public abstract PrimeSet Add(int newValue);
        public abstract void ForEach(Action<int> action);
    }

    public class Empty : PrimeSet
    {
        public override PrimeSet Add(int newValue)
        {
            return new NonEmpty(newValue, this);
        }

        public override void ForEach(Action<int> action)
        {
            ;
        }
    }

    public class NonEmpty : PrimeSet
    {
        public NonEmpty(int newValue, PrimeSet set)  
        {
            this.Value = newValue;
            this.Tail = set;
        }

        public readonly int Value;
        public readonly PrimeSet Tail;

        public override PrimeSet Add(int newValue)
        {
            return new NonEmpty(newValue, this);
        }

        public override void ForEach(Action<int> action)
        {
            action(this.Value);
            this.Tail.ForEach(action);
        }
    }
}