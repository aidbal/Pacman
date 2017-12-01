using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    abstract class PacmanSubject
    {
        private bool isEatable;
        private List<IEnemyObserver> observers = new List<IEnemyObserver>();

        public PacmanSubject(bool isEatable)
        {
            this.isEatable = isEatable;
        }

        public void Attach(IEnemyObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IEnemyObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IEnemyObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public bool State
        {
            get { return isEatable; }
            set
            {
                if (isEatable != value)
                {
                    isEatable = value;
                    Notify();
                }
            }
        }

        public void ChangeState()
        {
            isEatable = !isEatable;
            Notify();
        }
    }
}
