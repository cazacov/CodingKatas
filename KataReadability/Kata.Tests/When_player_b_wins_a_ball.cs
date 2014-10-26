using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame))]
    public class When_player_b_wins_a_ball : TestingContext
    {
        Establish context = () =>
        {
            game = new TennisGame();
        };

        Because of = () =>
        {
            game.PlayerBWinsBall();
        };

        It should_return_Points_1_for_PlayerB = () =>
        {
            game.PlayerBPoints.ShouldEqual(1);
        };

        It should_return_Points_0_for_PlayerA = () =>
        {
            game.PlayerAPoints.ShouldEqual(0);
        };
    }
}