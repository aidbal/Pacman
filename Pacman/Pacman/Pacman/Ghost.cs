using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class Ghost : IEnemy
    {
        public bool isEatable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void update()
        {
            isEatable = true;
        }
    }
}
