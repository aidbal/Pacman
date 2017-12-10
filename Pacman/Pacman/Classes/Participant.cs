using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Classes
{
    class Participant
    {
        public Chatroom Chatroom { set; get; }
        public string Name { get; }

        public Participant(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine("Message from {0} to {1}: '{2}'", from, Name, message);
        }
    }
}
