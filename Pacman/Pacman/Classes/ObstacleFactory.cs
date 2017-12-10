using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class ObstacleFactory
    {
        private static Hashtable hashtable = new Hashtable();

        public static Obstacle GetObstacle(int length)
        {
            Obstacle obs = (Obstacle) hashtable[length];

            if (obs == null)
            {
                obs = new Obstacle(length);
                hashtable.Add(length, obs);
                Console.WriteLine("Creating obstacle of length:" + length);
            }
            return obs;
        }
    }
}
