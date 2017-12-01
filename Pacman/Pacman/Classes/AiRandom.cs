﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class AiRandom : IEnemyStrategy
    {
        public void SetStrategy()
        {
            Debug.WriteLine("Setting strategy to random");
        }
    }
}
