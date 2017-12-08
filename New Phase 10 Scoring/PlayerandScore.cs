using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Phase_10_Scoring
{
    public class PlayerandScore
    {

        public static List<PlayerandScore> allPlayers = new List<PlayerandScore>();
        public static int totalPlayers;
        public static bool bGameOver;


        public string playerName;
        public int playerPhase;
        public int playerScore;

        public PlayerandScore(string inName)
        {
            playerName = inName;
            playerPhase = 1;
            playerScore = 0;

        }

        public static List<PlayerandScore> UpdateRanks()
        {
            List<PlayerandScore> tempPlayers = new List<PlayerandScore>();
            tempPlayers = allPlayers;

            tempPlayers = tempPlayers.OrderByDescending(PlayerandScore => PlayerandScore.playerPhase).ThenBy(PlayerandScore => PlayerandScore.playerScore).ToList();

            return tempPlayers;
        }
    }
}
