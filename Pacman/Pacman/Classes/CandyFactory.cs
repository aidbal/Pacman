using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman.Classes.Candies;

namespace Pacman.Classes
{
    class CandyFactory : AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            return null;
        }

        public override ICandy GetCandy(string candyType)
        {
            if (candyType == null)
            {
                return null;
            }
            if (candyType.Equals("small", StringComparison.InvariantCultureIgnoreCase))
            {
                return new SmallCandy();
            }
            if (candyType.Equals("big", StringComparison.InvariantCultureIgnoreCase))
            {
                return new BigCandy();
            }
            if (candyType.Equals("cherry", StringComparison.InvariantCultureIgnoreCase))
            {
                return new CherryCandy();
            }
            if (candyType.Equals("banana", StringComparison.InvariantCultureIgnoreCase))
            {
                return new BananaCandy();
            }
            return null;
        }
    }
}
