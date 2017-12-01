using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        // Singleton    done
        // Factory      done
        // Strategy     done
        // Observer     done

        // Adapter      done
        // Decorator    done
        // Facade       
        // Command      done

        

        public Form1()
        {
            InitializeComponent();
            instance = this;
            pacman = new Classes.Pacman(false);
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

            pacman.Attach(enemy);
            pacman.State = true;

            CandyFactory candyFactory = new CandyFactory();
            ICandy candy1 = candyFactory.CreateCandy("small");
            candy1.CreateCandy();

            ICandy candy2 = candyFactory.CreateCandy("big");
            candy2.CreateCandy();

            ICandy candy3 = candyFactory.CreateCandy("cherry");
            candy3.CreateCandy();

            ICandy candy4 = candyFactory.CreateCandy("BANANA");
            candy4.CreateCandy();

            //Decorator
            pacman.weapon = new Gun();
            Debug.WriteLine("Weapon damage = {0}, Weapon shoots = {1}", pacman.weapon.Damage(), pacman.weapon.Shoot());
            pacman.weapon = new Cannon(pacman.weapon);
            Debug.WriteLine("Weapon damage = {0}, Weapon shoots = {1}", pacman.weapon.Damage(), pacman.weapon.Shoot());
            pacman.weapon = new SpeedTrap(pacman.weapon);
            Debug.WriteLine("Weapon damage = {0}, Weapon shoots = {1}", pacman.weapon.Damage(), pacman.weapon.Shoot());


        }
    }
}
