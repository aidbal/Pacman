using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class Pacman
    {
        private int moveDirection;
        private int speed = 1;
        private IEnemy[] observers; 

        void notifyObservers()
        {
            foreach(IEnemy obs in observers){
                obs.
            }
        }

        void register(IEnemy obs)
        {

        }

        void unregister(IEnemy obs)
        {

        }

        void eat(ICandy candy)
        {

        }

        public void move()
        {
            throw new NotImplementedException();
        }

        public void move(int newDirection)
        {
            this.moveDirection = newDirection;
        }

        
    }
}
