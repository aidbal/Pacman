using System;
namespace Pacman
{
    public class Game
    {
        public static void Main(string[] args)
        {
            IGameBoardFacade GameBoard = new GameBoardFacade();
            Console.WriteLine("Starting game!");
            GameBoard.initialize();
            //var diSetup = new DependencyInjectionSetup().GetScope();
            //Gui gui = new GuiAdapter();
            //gui.InitializeGui();
        }
    }

}
