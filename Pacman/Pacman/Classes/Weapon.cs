using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    abstract class Weapon
    {
        public abstract int Damage();
        public abstract string Shoot();
    }
}
