using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman.Classes.Candies;
using Pacman.Classes.Colors;

namespace Pacman.Classes
{
    class FoodFacade
    {
        private BananaCandy bananaCandy;
        private BigCandy bigCandy;
        private SmallCandy smallCandy;
        private CherryCandy cherryCandy;
        private Yellow yellow;
        private Red red;

        public FoodFacade()
        {
            bananaCandy = new BananaCandy();
            bigCandy = new BigCandy();
            smallCandy = new SmallCandy();
            cherryCandy = new CherryCandy();
            yellow = new Yellow();
            red = new Red();
        }

        public void CreateYellowBanana()
        {
            Debug.WriteLine("Creating colorful candy");
            bananaCandy.CreateCandy();
            yellow.CreateColor();
            Debug.WriteLine("");
        }
        public void CreateRedCherry()
        {
            Debug.WriteLine("Creating colorful candy");
            cherryCandy.CreateCandy();
            red.CreateColor();
            Debug.WriteLine("");
        }
        public void CreateRedSmall()
        {
            Debug.WriteLine("Creating colorful candy");
            smallCandy.CreateCandy();
            red.CreateColor();
            Debug.WriteLine("");
        }
        public void CreateYellowBig()
        {
            Debug.WriteLine("Creating colorful candy");
            bigCandy.CreateCandy();
            yellow.CreateColor();
            Debug.WriteLine("");
        }
    }
}
