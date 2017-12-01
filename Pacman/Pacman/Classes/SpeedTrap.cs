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

        public override int Damage()
        {
            return base.Damage() + 10;
        }

        public override string Shoot()
        {
            if (this.weapon != null)
            {
                return base.Shoot() + " and slowing bullet";
            }
            return string.Empty;
        }
    }
}
