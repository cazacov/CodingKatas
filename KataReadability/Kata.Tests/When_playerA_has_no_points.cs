using Machine.Specifications;

namespace Kata.Tests
{
    [Subject(typeof(TennisGame))]
    public class When_playerA_has_no_points : TestingContext
    {
        Establish context = () =>
        {
            game = new TennisGame();
        };

        Because of = () =>
        {
        };

        It should_return_score_love = () =>
        {
            game.PlayerAScore.ShouldEqual(Score.Love);
        };
    }
}