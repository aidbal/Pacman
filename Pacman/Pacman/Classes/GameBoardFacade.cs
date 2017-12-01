using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class GameBoardFacade : IGameBoardFacade
    {
        private ILogger logger = new LoggerAdapter();
        private ILogger guiLogger = new GuiLoggerAdapter();

        public void initialize()
        {
            logger.LogMessage("Adapter Works!");
            guiLogger.LogMessage("Gui Logger Works!"); //Not yet
        }

        public void restart()
        {
            
        }
    }
}
