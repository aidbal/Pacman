using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class NullObject : AllScoresHandler
    {
        public override void HandleScore(int score)
        {
            if (score == 0)
            {
                Console.Write("NullObject handled request: " + score);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleScore(score);
            }
        }
    }
}
