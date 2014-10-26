using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame ))]
    public class When_playerA_got_4_Points : TestingContext 
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
            game.PlayerAWinsBall();
        };

        It should_return_player_A_has_won = () =>
        {
            game.State.ShouldEqual(GameState.PlayerAWins );
        };
    }
}