using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    interface IEnemy
    {
        bool isEatable { get; set; }

        void update();
    }
}
