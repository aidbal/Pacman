using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes.Colors
{
    class Yellow : IColor
    {
        public void CreateColor()
        {
            Debug.WriteLine("Yellow color was created.");
        }
    }
}
