using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Obstacle : IObstacle
    {
        private int _length, _x, _y, _rotation;

        public Obstacle(int length)
        {
            _length = length;
        }

        public void SetX(int x)
        {
            _x = x;
        }

        public void SetY(int y)
        {
            _y = y;
        }

        public void SetRotation(int rotation)
        {
            _rotation = rotation;
        }

        public void Draw()
        {
            Console.WriteLine("Obstacle: Draw() [Length: " + _length + ", x: " + _x 
                + ", y:" + _y + ", rotation: " + _rotation);
        }
    }
}
