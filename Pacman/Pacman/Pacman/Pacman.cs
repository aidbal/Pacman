using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class Pacman
    {
        private int moveDirection;
        private int speed = 1;

        public void move()
        {
            throw new NotImplementedException();
        }

        public void move(int newDirection)
        {
            this.moveDirection = newDirection;
        }
    }
}
