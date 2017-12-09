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
        public string Shoot()
        {
            if (HasRecoil())
            {
                return "Shoots with " + Damage() + " damage, sends Pacman " + Recoil() + " steps back";
            }
            if (HasFowardBoost())
            {
                return "Shoots with " + Damage() + " damage, boosts Pacman " + BoostFoward() + " steps foward";
            }
            return "Shoots with " + Damage() + " damage";
        }
        public abstract int Recoil();
        public abstract int BoostFoward();
        public virtual bool HasRecoil() { return true; }
        public virtual bool HasFowardBoost() { return true; }
    }
}
