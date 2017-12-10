using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class ShiftCounter : Counter
    {
        private Counter _bananaScore, _originalScore;

        public ShiftCounter(Counter banana, Counter original)
        {
            _bananaScore = banana;
            _originalScore = original;
        }

        public override int Count()
        {
            return _bananaScore.Count() + (_originalScore.Count() << 1);
        }
    }
}
