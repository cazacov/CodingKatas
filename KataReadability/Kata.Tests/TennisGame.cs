using System;

namespace Kata
{
    public class TennisGame
    {
        public int PlayerAPoints { get; private set; }

        public int PlayerBPoints { get; private set; }

        public Score PlayerAScore
        {
            get { return Points2Score(PlayerAPoints); }
        }

        public Score PlayerBScore
        {
            get { return Points2Score(PlayerBPoints); }
        }

        public GameState State
        {
            get
            {
                if (PlayerAPoints >= 4 && PlayerAPoints - PlayerBPoints >= 2)
                {
                    return GameState.PlayerAWins;
                }
                if (PlayerBPoints >= 4 && PlayerBPoints - PlayerAPoints >= 2)
                {
                    return GameState.PlayerBWins;
                }
                return GameState.running;
            }
        }

        public string TextResult
        {
            get { return String.Format("{0} - {1}", PlayerAScore, PlayerBScore); }
        }

        private Score Points2Score(int playerPoints)
        {
            switch (playerPoints)
            {
                case 0:
                    return Score.Love;
                case 1:
                    return Score.Fifteen;
                case 2:
                    return Score.Thirty;
                case 3:
                    return Score.Forty;
                default:
                    return Score.Advantage;
            }
        }

        public void PlayerAWinsBall()
        {
            PlayerAPoints++;
        }

        public void PlayerBWinsBall()
        {
            PlayerBPoints++;
        }
    }
}