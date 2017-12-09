using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Cannon : WeaponDecorator
    {
        public Cannon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override int BoostFoward()
        {
            return 0;
        }

        public override int Damage()
        {
            return base.Damage() + 100;
        }

        public override int Recoil()
        {
            return 2;
        }
        public override bool HasRecoil()
        {
            return true;
        }
        public override bool HasFowardBoost()
        {
            return false;
        }
    }
}
