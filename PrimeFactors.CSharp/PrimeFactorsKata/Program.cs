using System;

namespace PrimeFactorsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numer:");
            int value = int.Parse(Console.ReadLine());
            var results = new FactorFinder().CalculateResult(value);
            Console.WriteLine("Result is:");
            Console.WriteLine(string.Join(", ", results.ToList()));
            Console.ReadLine();
        }
    }
}
