using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class MoveDown : ICommand
    {
        private Pacman pacman;

        public MoveDown(Pacman pacman)
        {
            this.pacman = pacman;
        }

        public void Move()
        {
            pacman.moveDirection = 2;
            Debug.WriteLine("Pacman changed direction to: down");
        }
    }
}
