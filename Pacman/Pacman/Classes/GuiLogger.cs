using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class GuiLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Form1.Instance.richTextBox1.Text += message;
        }
    }
}
