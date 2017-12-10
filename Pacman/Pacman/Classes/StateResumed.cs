using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class StateResumed : IState
    {
        public void Handle(StateContext context)
        {
            Console.WriteLine("The game is in resumed state");
            context.SetState(this);
        }

        public String GetString()
        {
            return "Resumed state";
        }
    }
}
