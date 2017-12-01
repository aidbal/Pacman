using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class MoveUp : ICommand
    {
        private Pacman pacman;

        public MoveUp(Pacman pacman)
        {
            this.pacman = pacman;
        }

        public void Move()
        {
            pacman.moveDirection = 0;
            Debug.WriteLine("Pacman changed direction to: up");
        }
    }
}
