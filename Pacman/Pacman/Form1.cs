using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pacman.Classes;

namespace Pacman
{
    public partial class Form1 : Form
    {
        private Game game = new Game();
        private static Form1 instance;
        private Classes.Pacman pacman;

        public static Form1 Instance
        {
            get { return instance; }
        }

        public Form1()
        {
            InitializeComponent();
            instance = this;
            pacman = new Classes.Pacman();
            MoveDown moveDown = new MoveDown(pacman);
            MoveUp moveUp = new MoveUp(pacman);
            MoveLeft moveLeft = new MoveLeft(pacman);
            MoveRight moveRight = new MoveRight(pacman);


            game.startGame();

            pacman.Move(moveDown);
            pacman.Move(moveUp);
            pacman.Move(moveLeft);
            pacman.Move(moveRight);

            Enemy enemy = new Enemy(new AiAmbusher());
            enemy.SelectStrategy();
            enemy.strategy = new AiRandom();
            enemy.SelectStrategy();
        }

        //public Form1()
        //{
        //    InitializeComponent();
        //    game.startGame();
        //}
    }
}
