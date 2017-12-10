using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Highscore
    {
        public int score { set; get; }
        private static readonly Highscore highscore = new Highscore();
        static Highscore() { } // Make sure it's truly lazy
        private Highscore()
        {
            score = 0;
        } // Prevent instantiation outside

        public static Highscore Instance { get { return highscore; } }
    }
}
