using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame))]
    public class When_game_is_not_played_yet : TestingContext
    {
        Establish context = () =>
        {
           game = new TennisGame();
        };

        Because of = () =>
        {
            // do nothing, as the game is not started yet
        };

        It should_return_zero_Points_for_both_players = () =>
        {
            game.PlayerAPoints.ShouldEqual(0);
            game.PlayerBPoints.ShouldEqual(0);
        };
    }
}