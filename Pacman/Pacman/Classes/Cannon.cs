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

        public override int Damage()
        {
            return base.Damage() + 100;
        }

        public override string Shoot()
        {
            if (weapon != null)
            {
                return base.Shoot() + " and instant-kill bullets";
            }
            return string.Empty;
        }
    }
}
