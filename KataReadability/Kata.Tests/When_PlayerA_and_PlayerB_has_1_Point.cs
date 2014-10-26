using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame))]
    public class When_PlayerA_and_PlayerB_has_1_Point : TestingContext
    {
        Establish context = () =>
        {
            game = new TennisGame();    
        };

        Because of = () =>
        {
            game.PlayerAWinsBall();
            game.PlayerBWinsBall();
        };

        It should_return_game_is_running = () =>
        {
            game.State.ShouldEqual(GameState.running);

        };
    }
}