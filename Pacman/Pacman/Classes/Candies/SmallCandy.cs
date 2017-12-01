using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes.Candies
{
    class SmallCandy : ICandy
    {
        public void CreateCandy()
        {
            Debug.WriteLine("Small candy was created.");
        }
    }
}
