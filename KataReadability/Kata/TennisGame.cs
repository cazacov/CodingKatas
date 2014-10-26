using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata;

namespace Kata
{
    
        public enum Score
        {
            love,
            Fifteen,
            Thirty,
            Fourty,
            Advantage,
            deuce
        }
    

    public class TennisGame
    {
        public int PlayerAPoints { get; private set; }

        public int PlayerBPoints { get; private set; }

        public Score PlayerAScore {
            get { return Points2Score(PlayerAPoints); } 
        }

        public Score PlayerBScore
        {
            get { return Points2Score(PlayerBPoints); }
        }

        private Score Points2Score(int playerPoints)
        {
            switch (playerPoints)
            {
                case 0:
                    return Score.love;
                case 1:
                    return Score.Fifteen;
                case 2:
                    return Score.Thirty;
                case 3:
                    return Score.Fourty;
                default:
                    return Score.Advantage;
            }
        }

  public GameState State
        {
            get
            {
                if (PlayerAPoints >= 4 && PlayerAPoints - PlayerBPoints >= 2)
                {
                    return GameState.PlayerAWins;
                }
                else if (PlayerBPoints >= 4 && PlayerBPoints - PlayerAPoints >= 2)
                {
                    return GameState.PlayerBWins;
                }
                else
                {
                    return GameState.running;
                }
            }
        }

        public string TextResult {
            get { return String.Format("{0} - {1}", ToTextResult(this.PlayerAPoints), ToTextResult(this.PlayerBPoints)); }
        }

        private string ToTextResult(int playerPoints)
        {
            if (playerPoints == 0)
            {
                return "love";
            }
            if (playerPoints == 2) // 30
            {
                return "thirty";
            }
            if (playerPoints == 3) // 40
            {
                return "forty";
            }
            return String.Empty;
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
