using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes.Colors
{
    class Red : IColor
    {
        public void CreateColor()
        {
            Debug.WriteLine("Red color was created.");
        }
    }
}
