using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    interface ICommand
    {
        Pacman controllable { get; set; }

        void move(int newDirection);
    }
}
