using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Game
    {
        private IGameBoardFacade GameBoard = new GameBoardFacade();
        private GuiLoggerAdapter GuiAdapter = new GuiLoggerAdapter();

        public void startGame()
        {
            GameBoard.initialize();
        }

        public void restartGame()
        {
            
        }
    }
}
