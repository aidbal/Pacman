using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class WeaponDecorator : IWeapon
    {
        private IWeapon parentWeapon;
        public string getWeapons()
        {
            return parentWeapon.ToString();
        }
    }
}
