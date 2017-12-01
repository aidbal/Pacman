using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman.Classes.Colors;

namespace Pacman.Classes
{
    class ColorFactory : AbstractFactory
    {
        public override ICandy GetCandy(string candyType)
        {
            return null;
        }

        public override IColor GetColor(string colorType)
        {
            if (colorType == null)
            {
                return null;
            }
            if (colorType.Equals("yellow", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Yellow();
            }
            if (colorType.Equals("red", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Red();
            }
            return null;
        }
    }
}
