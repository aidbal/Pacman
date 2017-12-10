using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    interface IState
    {
        void Handle(StateContext context);
        String GetString();
    }
}
