using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class ProxyBackgroundImage : IBackgroundImage
    {
        private BackgroundImage _backgroundImage;
        private String _filename;

        public ProxyBackgroundImage(String filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_backgroundImage == null)
            {
                _backgroundImage = new BackgroundImage(_filename);
            }
            _backgroundImage.Display();
        }
    }
}
