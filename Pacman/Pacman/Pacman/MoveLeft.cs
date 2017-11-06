using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class MoveLeft : ICommand
    {
        public Pacman controllable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void move(int newDirection)
        {
            this.controllable.move(4);
        }
    }
}
