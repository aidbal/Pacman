using System;
namespace Pacman
{
    public class Game
    {
        public static void Main(string[] args)
        {
            var diSetup = new DependencyInjectionSetup().GetScope();
            Gui gui = new GuiAdapter();
            gui.InitializeGui();
        }
    }

}
