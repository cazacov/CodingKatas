using System.Linq;
using NUnit.Framework;

namespace PrimeFactorsKata.Tests
{
    [TestFixture]
    public class PrimeFactorTest
    {
        [Test]
        public void WhenCalculatingPrimeFactor_ShouldReturnCorrectResult()
        {
            int value = 1;
            var results = new FactorFinder().CalculateResult(value).ToList();
            Assert.IsEmpty(results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of0_ShouldReturnEmptySet()
        {
            int value = 0;
            var results = new FactorFinder().CalculateResult(value).ToList();
            Assert.IsEmpty(results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of7_ShouldReturn7()
        {
            int value = 7;
            var results = new FactorFinder().CalculateResult(value).ToList();
            CollectionAssert.AreEquivalent(new[] { 7 }, results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of2_ShouldGet2()
        {
            int value = 2;
            var results = new FactorFinder().CalculateResult(value).ToList();
            
            CollectionAssert.AreEquivalent(new []{2}, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of3_ShouldGet3()
        {
            int value = 3;
            var results = new FactorFinder().CalculateResult(value).ToList();

            CollectionAssert.AreEquivalent(new[] { 3 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of4_ShouldGet22()
        {
            int value = 4;
            var results = new FactorFinder().CalculateResult(value).ToList();

            CollectionAssert.AreEquivalent(new[] { 2, 2 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of100_ShouldGet2255()
        {
            int value = 100;
            var results = new FactorFinder().CalculateResult(value).ToList();

            CollectionAssert.AreEquivalent(new[] { 2, 5, 2, 5 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of126_ShouldGet()
        {
            int value = 126;
            var results = new FactorFinder().CalculateResult(value).ToList();

            CollectionAssert.AreEquivalent(new[] { 2, 3, 3, 7 }, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of2hoch30_ShouldGet30_2()
        {
            int value = 1048576 * 1024;
            var results = new FactorFinder().CalculateResult(value).ToList();

            var expected = Enumerable.Range(1, 30).Select(x => 2);

            CollectionAssert.AreEquivalent(expected, results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of2hoch720_ShouldGet2222335()
        {
            int value = 720;
            var results = new FactorFinder().CalculateResult(value).ToList();

            CollectionAssert.AreEquivalent(new []{2,2,2,2,3,3,5}, results);

        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of11Factorial_IsOk()
        {
            int value = 39916800;
            var results = new FactorFinder().CalculateResult(value).ToList();

            CollectionAssert.AreEquivalent(new[] {2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 5, 5, 7, 11}, results);
        }

        [Test]
        public void WhenCalculatingPrimeFactor_Of1048573_IsOk()
        {
            int value = 1048573;
            var results = new FactorFinder().CalculateResult(value).ToList();

            CollectionAssert.AreEquivalent(new[] { 1048573 }, results);
        }
    }
}
