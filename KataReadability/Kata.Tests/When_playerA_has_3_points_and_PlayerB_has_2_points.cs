using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame))]
    public class When_playerA_has_3_points_and_PlayerB_has_2_points : TestingContext
    {
        Establish context = () =>
        {
            game = new TennisGame();
        };

        Because of = () =>
        {
            game.PlayerAWinsBall();
            game.PlayerAWinsBall();
            game.PlayerAWinsBall();

            game.PlayerBWinsBall();
            game.PlayerBWinsBall();
        };

        It should_result_be_thirty_fifteen = () =>
        {
            game.TextResult.ShouldEqual("Forty - Thirty");
        };
    }
}