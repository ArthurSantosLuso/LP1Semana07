using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStats
{
    class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;

        public float HighScore
        {
            get => highScore;

            set
            {
                if (highScore < value)
                    highScore = value;
            }
        }
        public string Name { get; set; }
        public float WinRate
        {
            get
            {
                if (playedGames > 0)
                    return wonGames / playedGames;
                else
                    return 0;
            }
        }
    }
}
