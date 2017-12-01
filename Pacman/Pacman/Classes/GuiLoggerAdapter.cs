using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class GuiLoggerAdapter : ILogger
    {
        private GuiLogger guiLogger = new GuiLogger();

        public void LogMessage(string message)
        {
            guiLogger.LogMessage(message);
        }
    }
}
