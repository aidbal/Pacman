using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class MoveRight : ICommand
    {
        private Pacman pacman;

        public MoveRight(Pacman pacman)
        {
            this.pacman = pacman;
        }

        public void Move()
        {
            pacman.moveDirection = 1;
            Debug.WriteLine("Pacman changed direction to: right");
        }
    }
}
