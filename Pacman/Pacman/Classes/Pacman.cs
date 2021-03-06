﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Pacman : PacmanSubject
    {
        public int moveDirection { set; get; }
        private int speed;
        private int locationX;
        private int locationY;
        public Weapon weapon { set; get; }

        public Pacman(bool isEatable) : base(isEatable)
        {
        }

        public void notifyObservers()
        {
            
        }

        public void register()
        {
            
        }

        public void unregister()
        {
            
        }

        public void eat()
        {
            
        }

        public void Move(ICommand command)
        {
            command.Move();
        }

        public void getWeapon()
        {
            
        }

        public void setWeapon()
        {
            
        }
    }
}
