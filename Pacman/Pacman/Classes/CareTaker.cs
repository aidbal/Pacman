using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento score)
        {
            mementoList.Add(score);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }

        public Memento GetLast()
        {
            return mementoList[mementoList.Count-1];
        }
    }
}
