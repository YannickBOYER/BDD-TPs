using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    public class Player
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int scoreTemp;
        public int Throws { get; set; }
        public Player(int id, int score, int throws)
        {
            Id = id;
            Score = score;
            Throws = throws;
        }
        public void ThrowDart(int area, int multiplier)
        {
            // Check if the area is valid
            if (area < 1 || area > 20 && area != 25)
            {
                throw new ArgumentException("Invalid area");
            }
            // Check if the multiplier is valid
            if (multiplier < 1 || multiplier > 3 || area == 25 && multiplier > 2)
            {
                throw new ArgumentException("Invalid multiplier");
            }
            // Check if the score is valid
            if (Score - (area * multiplier) < 0)
            {
                // print a console message to say the player Busted
                Console.WriteLine("Player " + Id + " Busted");
            }
            // Update the score
            Score -= area * multiplier;
        }
        public void PlayATurn(Round round)
        {
            int scoreBeforePlaying = Score;
            for (int i = 0; i < round.Areas.Count; i++)
            {
                ThrowDart(round.Areas[i], round.Multipliers[i]);
            }
            if (Score == 0)
            {
                Console.WriteLine("Player " + Id + " wins");
            }
            else if (Score < 0)
            {
                Score = scoreBeforePlaying;
            }
            else
            {
                Console.WriteLine(round.Areas.Count + " darts thrown, " + Score + " points left");
            }
        }
    }
}
