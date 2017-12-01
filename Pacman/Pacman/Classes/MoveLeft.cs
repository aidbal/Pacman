using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class MoveLeft : ICommand
    {
        private Pacman pacman;

        public MoveLeft(Pacman pacman)
        {
            this.pacman = pacman;
        }

        public void Move()
        {
            pacman.moveDirection = 3;
            Debug.WriteLine("Pacman changed direction to: left");
        }
    }
}
