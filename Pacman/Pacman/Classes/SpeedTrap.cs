using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class SpeedTrap : WeaponDecorator
    {
        public SpeedTrap(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int BoostFoward()
        {
            return 2;
        }

        public override int Damage()
        {
            return base.Damage() + 10;
        }

        public override int Recoil()
        {
            return 0;
        }

        public override bool HasRecoil()
        {
            return false;
        }
        public override bool HasFowardBoost()
        {
            return true;
        }
    }
}
