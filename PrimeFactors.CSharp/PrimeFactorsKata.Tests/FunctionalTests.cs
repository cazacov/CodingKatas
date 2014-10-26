using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PrimeFactorsKata.FSharp;

namespace PrimeFactorsKata.Tests
{
    [TestFixture]
    public class FunctionalTests
    {
        private IFactorFinder factorFinder;

        [Test]
        public void WhenCalculatingPrimeFactor_ShouldReturnCorrectResult()
        {
            const long number = 1L;
            var results = factorFinder.FindFactors(number).ToList();
            Assert.IsEmpty(results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of0_ShouldReturnEmptySet()
        {
            const long number = 0L;
            var results = factorFinder.FindFactors(number).ToList();
            Assert.IsEmpty(results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of7_ShouldReturn7()
        {
            const long number = 7L;
            var results = factorFinder.FindFactors(number).ToList();
            CollectionAssert.AreEquivalent(new[] { 7 }, results);
        }


        [Test]
        public void WhenCalculatingPrimeFactor_Of2_ShouldGet2()
        {
            const long number = 2L;
            var results = factorFinder.FindFactors(number).ToList();
            CollectionAssert.AreEquivalent(new[] { 2 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of3_ShouldGet3()
        {
            const long number = 3L;
            var results = factorFinder.FindFactors(number).ToList();
            CollectionAssert.AreEquivalent(new[] { 3 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of4_ShouldGet22()
        {
            const long number = 4L;
            var results = factorFinder.FindFactors(number).ToList();
            CollectionAssert.AreEquivalent(new[] { 2, 2 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of100_ShouldGet2255()
        {
            const long number = 100L;
            var results = factorFinder.FindFactors(number).ToList();
            CollectionAssert.AreEquivalent(new[] { 2, 5, 2, 5 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of126_ShouldGet()
        {
            const long number = 126L;
            var results = factorFinder.FindFactors(number).ToList();
            CollectionAssert.AreEquivalent(new[] { 2, 3, 3, 7 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of2hoch30_ShouldGet30_2()
        {
            const long number = 1048576L * 1024L;
            var results = factorFinder.FindFactors(number).ToList();

            var expected = Enumerable.Range(1, 30).Select(x => 2);

            CollectionAssert.AreEquivalent(expected, results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of2hoch720_ShouldGet2222335()
        {
            const long number = 720;
            var results = factorFinder.FindFactors(number).ToList();

            CollectionAssert.AreEquivalent(new[] { 2, 2, 2, 2, 3, 3, 5 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of11Factorial_IsOk()
        {
            const long number = 39916800L;
            var results = factorFinder.FindFactors(number).ToList();

            CollectionAssert.AreEquivalent(new[] { 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 5, 5, 7, 11 }, results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of1048573_IsOk()
        {
            const long number = 1048573;
            var results = factorFinder.FindFactors(number).ToList();

            CollectionAssert.AreEquivalent(new[] { 1048573 }, results);
        }

        [Test]
        public void Mersenne31_IsPrime()
        {
            const long number = 2147483647L;
            var results = factorFinder.FindFactors(number).ToList();

            CollectionAssert.AreEquivalent(new[] { 2147483647L }, results);
        }

        [Test]
        [Ignore]
        public void Mersenne61_IsPrime()
        {
            const long number = 2305843009213693951L;
            var results = factorFinder.FindFactors(number).ToList();

            CollectionAssert.AreEquivalent(new[] { 2305843009213693951L }, results);
        }

        [Test]
        public void TwoPower63Minus1_IsNotPrime()
        {
            const long number = 9223372036854775807L;
            var results = factorFinder.FindFactors(number).ToList();

            CollectionAssert.AreEquivalent(new[] { 7, 7, 73, 127, 337, 92737, 649657}, results);
        }

        [SetUp]
        public void GetFactorFinder()
        {
            this.factorFinder = new FunctionalPrimeFinder();
        }
    }
}
