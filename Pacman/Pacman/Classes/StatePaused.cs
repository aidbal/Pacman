using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class StatePaused : IState
    {
        public void Handle(StateContext context)
        {
            Console.WriteLine("The game is in paused state");
            context.SetState(this);
        }

        public String GetString()
        {
            return "Paused state";
        }
    }
}
