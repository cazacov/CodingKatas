using System;
using System.Linq;
using NSubstitute;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    /// <summary>
    /// Unit tests of the FizzBuzzGame
    /// </summary>
    [TestFixture]
    class FizzBuzzGameTests
    {
        [Category("Invariants")]
        [Test]
        public void PlayingGame_Always_Prints100Strings()
        {
            // Arrange
            var printerMock = Substitute.For<IResultPrinter>();
            var game = new FizzBuzzGame(printerMock);

            // Act
            game.PlayTheGame();

            // Assert
            printerMock.Received(100).Print(Arg.Any<string>());
        }

        [Category("Positive tests")]
        [Test]
        public void PlayingGame_AsTheFirstString_Returns1()
        {
            // Arrange
            var printerMock = new ResultPrinterMock();
            var game = new FizzBuzzGame(printerMock);

            // Act
            game.PlayTheGame();

            // Assert
            var firstResult = printerMock.GetMessageWithIndex(1);
            Assert.AreEqual("1", firstResult);
        }

        [Category("Positive tests")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        public void PlayingGame_ForMultiplesOfThree_ReturnsFizz(int index, string expected)
        {
            // Arrange
            var printerMock = new ResultPrinterMock();
            var game = new FizzBuzzGame(printerMock);

            // Act
            game.PlayTheGame();

            // Assert
            var actual = printerMock.GetMessageWithIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [Category("Positive tests")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        public void PlayingGame_ForMultiplesOfFive_ReturnsBuzz(int index, string expected)
        {
            // Arrange
            var printerMock = new ResultPrinterMock();
            var game = new FizzBuzzGame(printerMock);

            // Act
            game.PlayTheGame();

            // Assert
            var actual = printerMock.GetMessageWithIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [Category("Positive tests")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void PlayingGame_ForMultiplesOfBothThreeAndFive_ReturnsFizzBuzz(int index, string expected)
        {
            // Arrange
            var printerMock = new ResultPrinterMock();
            var game = new FizzBuzzGame(printerMock);

            // Act
            game.PlayTheGame();

            // Assert
            var actual = printerMock.GetMessageWithIndex(index);
            Assert.AreEqual(expected, actual);

        }

        [Category("Invariants")]
        [Test]
        public void PlayingGame_Allways_ReturnsNumberOrFizzOrBuzzOrFizzBuzz()
        {
            // Arrange
            var printerMock = Substitute.For<IResultPrinter>();
            var game = new FizzBuzzGame(printerMock);

            // Act
            game.PlayTheGame();

            // Assert
            printerMock.DidNotReceive().Print(Arg.Is<String>(arg => !(
                AssertHelper.IsPositiveInteger(arg)
                || AssertHelper.IsFizz(arg)
                || AssertHelper.IsBuzz(arg)
                || AssertHelper.IsFizzBuzz(arg))));
        }

        [Category("Invariants")]
        [Test]
        public void PlayingGame_AllNumbers_AreNotMultiplesOfThreeOrFive()
        {
            // Arrange
            var printerMock = new ResultPrinterMock();
            var game = new FizzBuzzGame(printerMock);

            // Act
            game.PlayTheGame();

            Assert.True(printerMock.AllPrintedMessages().All(s =>
            {
                if (!AssertHelper.IsPositiveInteger(s))
                {
                    return true;
                }

                var intVal = Int32.Parse(s);
                return intVal % 3 != 0 && intVal % 5 != 0;
            }));
        }
    }
}
