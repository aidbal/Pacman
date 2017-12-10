using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Memento
    {
        private int _score;

        public Memento(int score)
        {
            _score = score;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
