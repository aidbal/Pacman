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

        public override int Recoil()
        {
            return 0;
        }
        public override int BoostFoward()
        {
            return 0;
        }
        public override bool HasFowardBoost()
        {
            return false;
        }
        public override bool HasRecoil()
        {
            return false;
        }
    }
}
