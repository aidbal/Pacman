using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Gun : Weapon
    {
        public override int Damage()
        {
            return 10;
        }

        public override string Shoot()
        {
            return "Shooting simple bullet";
        }
    }
}
