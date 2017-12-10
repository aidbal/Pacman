using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    abstract class AllScoresHandler
    {
        protected AllScoresHandler nextHandler;

        public void SetNextHandler(AllScoresHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public abstract void HandleScore(int score);
    }
}
