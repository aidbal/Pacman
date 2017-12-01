using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Enemy : IEnemyObserver
    {
        private bool isEatable;
        private int health;
        public IEnemyStrategy strategy { get; set; }

        public Enemy(IEnemyStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SelectStrategy()
        {
            strategy.SetStrategy();
        }

        public void Update(PacmanSubject subject)
        {
            Debug.WriteLine("Pacman changed it's state to " + subject.State);
        }
    }
}
