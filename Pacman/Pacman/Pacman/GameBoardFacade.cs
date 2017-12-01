using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    class GameBoardFacade : IGameBoardFacade
    {
        private Pacman player;
        private List<Enemy> enemies;
        private GuiAdapter guiAdapter;
        private readonly GameBoard _gameboard = new GameBoard();


        public GameBoardFacade()
        {
            enemies = new List<Enemy>();
            player = new Pacman();
            guiAdapter = new GuiAdapter();
        }

        public void initialize()
        {
            guiAdapter.initializeGui();

            _gameboard.generateCandies();
            Enemy enemy = new Enemy(new AiAmbusher());
            enemies.Add(enemy);
            Enemy enemy2 = new Enemy(new AiRandom());
            enemies.Add(enemy2);
            Enemy enemy3 = new Enemy(new AiChaser());
            enemies.Add(enemy3);
            foreach (var en in enemies)
            {
                en.getStrategy();
            }

        }

        public void restart()
        {
            _gameboard.removeLeftoverCandies();
            initialize();
        }
    }
}
