using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    abstract class WeaponDecorator : Weapon
    {
        protected Weapon weapon = null;

        public override int Damage()
        {
            return weapon.Damage();
        }

        public override string Shoot()
        {
            return weapon.Shoot();
        }
    }
}
