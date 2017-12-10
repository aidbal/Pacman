using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class BackgroundImage : IBackgroundImage
    {
        private String _filename;

        public BackgroundImage(String filename)
        {
            _filename = filename;
            LoadFromDisk(filename);
        }

        public void Display()
        {
            Console.WriteLine("Displaying background image: " + _filename);
        }

        public void LoadFromDisk(String filename)
        {
            Console.WriteLine("Loading image from disk: " + _filename);
        }
    }
}
