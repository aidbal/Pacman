﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class MoveRight : ICommand
    {
        public Pacman controllable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void move(int newDirection)
        {
            this.controllable.move(2);
        }
    }
}
