using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    abstract class AbstractFactory
    {
        public abstract ICandy GetCandy(string candyType);
        public abstract IColor GetColor(string colorType);
    }
}
