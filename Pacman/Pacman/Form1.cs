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
        private static Form1 instance;
        private Classes.Pacman pacman;
        private ILogger logger = new LoggerAdapter();
        private ILogger guiLogger = new GuiLoggerAdapter();

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
        // Facade       done
        // Command      done

        // Template Method - zaidimo temos
        // State - zaidimo busena
        // Proxy - 
        // Iterator, Composite, Flyweight

        // Chain of Responsibility
        // Null Object - score null
        // Memento - restart/resume game
        // Visitor - when enemies die, they visit visitor
        // Interpreter - custom game mod



        public Form1()
        {
            InitializeComponent();
            instance = this;

            //Singleton and Adapter
            logger.LogMessage("Adapter Works!");
            guiLogger.LogMessage("Gui Logger Works!");

            pacman = new Classes.Pacman(false);
            MoveDown moveDown = new MoveDown(pacman);
            MoveUp moveUp = new MoveUp(pacman);
            MoveLeft moveLeft = new MoveLeft(pacman);
            MoveRight moveRight = new MoveRight(pacman);

            //Command
            pacman.Move(moveDown);
            pacman.Move(moveUp);
            pacman.Move(moveLeft);
            pacman.Move(moveRight);

            //Strategy
            Enemy enemy = new Enemy(new AiAmbusher());
            enemy.SelectStrategy();
            enemy.strategy = new AiRandom();
            enemy.SelectStrategy();

            //Observer
            pacman.Attach(enemy);
            pacman.State = true;

            //Abstract factory
            AbstractFactory candyFactory = new CandyFactory();
            ICandy candy1 = candyFactory.GetCandy("small");
            candy1.CreateCandy();

            ICandy candy2 = candyFactory.GetCandy("big");
            candy2.CreateCandy();

            ICandy candy3 = candyFactory.GetCandy("cherry");
            candy3.CreateCandy();

            ICandy candy4 = candyFactory.GetCandy("BANANA");
            candy4.CreateCandy();

            AbstractFactory colorFactory = new ColorFactory();
            IColor color1 = colorFactory.GetColor("yellow");
            color1.CreateColor();

            IColor color2 = colorFactory.GetColor("red");
            color2.CreateColor();

            //Facade
            FoodFacade food = new FoodFacade();
            food.CreateRedCherry();
            food.CreateRedSmall();
            food.CreateYellowBanana();
            food.CreateYellowBig();

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
