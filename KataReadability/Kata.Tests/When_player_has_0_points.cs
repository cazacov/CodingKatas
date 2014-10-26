using System;
using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame))]
    public class When_player_has_0_points : TestingContext
    {
        Establish context = () =>
        {
            game = new TennisGame();
        };

        Because of = () =>
        {
        };

        It should_result_be_love_love = () =>
        {
            String textResult = game.TextResult;

            textResult.ShouldEqual("Love - Love");

        };
    }
}