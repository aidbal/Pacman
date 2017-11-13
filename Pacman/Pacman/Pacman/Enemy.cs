using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class Enemy : IEnemyObserver
    {
        private bool isEatable = false;
        private int health;
        private IEnemyStrategy enemyStrategy;

        public void takeDamage(int dmg)
        {
            health = health - dmg;
        }

        public void changeEatableState()
        {
            if(isEatable)
            {
                isEatable = false;
            } else
            {
                isEatable = true;
            }
        }

        public bool getEatableState()
        {
            return isEatable;
        }

        public IEnemyStrategy getStrategy()
        {
            return enemyStrategy;
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
