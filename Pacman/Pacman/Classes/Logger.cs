using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Logger
    {
        private static readonly Logger logger = new Logger();
        static Logger() { } // Make sure it's truly lazy
        private Logger() { } // Prevent instantiation outside

        public static Logger Instance { get{ return logger; } }

        public void LogMessage(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
