using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class PointsHandler : AllScoresHandler
    {
        public override void HandleScore(int score)
        {
            if (score < 10)
            {
                Console.Write("PointsHandler handled request: " + score);
                Highscore.Instance.score += score;
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleScore(score);
            }
        }
    }
}
