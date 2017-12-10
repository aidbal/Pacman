using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class BonusHandler : AllScoresHandler
    {
        public override void HandleScore(int score)
        {
            if (score >= 10)
            {
                Console.WriteLine("BonusHandler handled request: " + score);
                Highscore.Instance.score += score * 2;
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleScore(score);
            }
        }
    }
}
