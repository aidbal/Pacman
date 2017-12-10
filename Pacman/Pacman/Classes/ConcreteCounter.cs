using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class ConcreteCounter : Counter
    {
        private int _value;

        public ConcreteCounter(int value)
        {
            _value = value;
        }

        public override int Count()
        {
            return _value;
        }
    }
}
