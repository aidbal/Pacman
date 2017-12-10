using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //Decorator with Template Method
            pacman.weapon = new Gun();
            Debug.WriteLine(pacman.weapon.Shoot());
            pacman.weapon = new Cannon(pacman.weapon);
            Debug.WriteLine(pacman.weapon.Shoot());
            pacman.weapon = new SpeedTrap(pacman.weapon);
            Debug.WriteLine(pacman.weapon.Shoot());

            // State
            // Changes game state from resumed to paused and vice versa
            StateContext stateContext = new StateContext();
            StateResumed stateResumed = new StateResumed();
            StatePaused statePaused = new StatePaused();

            stateResumed.Handle(stateContext);
            Console.WriteLine(stateContext.GetState().GetString());
            statePaused.Handle(stateContext);
            Console.WriteLine(stateContext.GetState().GetString());

            // Proxy
            // Loads background image for gameboard
            IBackgroundImage image = new ProxyBackgroundImage("Background1.jpg");
            image.Display();
            Console.WriteLine("");
            // Image will not be loaded from disk again
            image.Display();

            // Flyweight
            // Pattern used to generate obstacles based on their length

            for (int i = 0; i < 8; i++)
            {
                //Creating duplicate objects
                Obstacle obs = ObstacleFactory.GetObstacle(i < 4 ? i : i/2);
                obs.SetX(4);
                obs.SetY(4);
                obs.SetRotation(0);
                obs.Draw();
            }

            // Chain of responsibility
            // For handling scores
            AllScoresHandler handler1 = new NullObject();
            AllScoresHandler handler2 = new BonusHandler();
            AllScoresHandler handler3 = new PointsHandler();
            handler1.SetNextHandler(handler2);
            handler2.SetNextHandler(handler3);
            int[] points = { 0, 15, 5, 10, -5, 16, 18, 0, 0, 13, 1, 2, 3};
            foreach (int point in points)
            {
                handler1.HandleScore(point);
            }
            Console.WriteLine("Final points: " + Highscore.Instance.score);

            // Mediator
            // Implemented chatroom
            Chatroom chatroom = new Chatroom();

            Participant player = new Participant("Player");
            Participant spectator1 = new Participant("Spectator1");
            Participant spectator2 = new Participant("Spectator2");

            chatroom.Register(player);
            chatroom.Register(spectator1);
            chatroom.Register(spectator2);

            player.Send("Spectator1", "Hello, spectator!");
            spectator1.Send("Player", "Hello, player!");
            spectator2.Send("Player", "Hey, don't forget me!");

            // Memento
            // Saving player score for later use
            CareTaker careTaker = new CareTaker();
            careTaker.Add(Highscore.Instance.SetMemento());
            Console.WriteLine("Memento saved state: " + careTaker.Get(0).GetScore());
            Highscore.Instance.score = 2222;
            careTaker.Add(Highscore.Instance.SetMemento());
            Console.WriteLine("Memento saved state: " + careTaker.Get(1).GetScore());
            Console.WriteLine("Restoring to first memento.");
            Highscore.Instance.SetMemento(careTaker.Get(0));
            Console.WriteLine("Restored score is: " + Highscore.Instance.score);

            // Interpreter
            // Eating yellow banana will binary shift your score to the left and add 10 points to the result
            Console.WriteLine("Score before interpreter: " + Highscore.Instance.score);
            Counter originalCounter = new ConcreteCounter(Highscore.Instance.score);
            Counter bananaCounter = new ConcreteCounter(10);
            Counter counter = new ShiftCounter(bananaCounter, originalCounter);

            Highscore.Instance.score = counter.Count();
            Console.WriteLine("Score before interpreter: " + Highscore.Instance.score);
        }
    }
}
