using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    /// <summary>
    /// Unit tests of the FizzBuzzGame
    /// </summary>
    [TestFixture]
    class FizzBuzzGameTests
    {
        [Test]
        public void PlayingGame_Always_Generates100Strings()
        {
            var game = new FizzBuzzGame();
            var gameResult = game.PlayTheGame();
            Assert.AreEqual(100, gameResult.Count());
        }

        [Test]
        public void PlayingGame_AsTheFirstString_Returns1()
        {
            var game = new FizzBuzzGame();
            var firstResult = game.PlayTheGame().First();
            Assert.AreEqual("1", firstResult);
        }

        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        public void PlayingGame_ForMultiplesOfThree_ReturnsFizz(int index, string expected)
        {
            var game = new FizzBuzzGame();
            var results = game.PlayTheGame().ToArray();
            Assert.AreEqual(expected, results[index-1]); // Arrays are zero-bazed
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        public void PlayingGame_ForMultiplesOfFive_ReturnsBuzz(int index, string expected)
        {
            var game = new FizzBuzzGame();
            var results = game.PlayTheGame().ToArray();
            Assert.AreEqual(expected, results[index - 1]); // Arrays are zero-bazed
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void PlayingGame_ForMultiplesOfBothThreeAndFive_ReturnsFizzBuzz(int index, string expected)
        {
            var game = new FizzBuzzGame();
            var results = game.PlayTheGame().ToArray();
            Assert.AreEqual(expected, results[index - 1]); // Arrays are zero-bazed
        }
    }
}
