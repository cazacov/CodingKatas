using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame))]
    public class When_player_a_wins_a_ball : TestingContext
    {
        Establish context = () =>
        {
            game = new TennisGame();
        };

        Because of = () =>
        {
            game.PlayerAWinsBall();
        };

        It should_return_Points_1_for_PlayerA = () =>
        {
            game.PlayerAPoints.ShouldEqual(1);
        };
        It should_return_Points_0_for_PlayerB = () =>
        {
            game.PlayerBPoints.ShouldEqual(0);
        };
    }
}