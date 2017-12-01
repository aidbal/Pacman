using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class LoggerAdapter : ILogger
    {   
        public void LogMessage(string message)
        {
            Logger.Instance.LogMessage(message);
        }
    }
}
