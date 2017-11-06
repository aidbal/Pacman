using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class Thief : IEnemy
    {
        public bool isEatable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void update()
        {
            isEatable = true;
        }
    }
}
