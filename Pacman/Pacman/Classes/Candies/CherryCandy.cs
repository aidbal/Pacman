﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes.Candies
{
    class CherryCandy : ICandy
    {
        public void CreateCandy()
        {
            Debug.WriteLine("Cherry candy was created.");
        }
    }
}
