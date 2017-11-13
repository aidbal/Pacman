using System;
namespace Pacman
{
    public class Banana : ICandy
    {
        int locationX;
        int locationY;
        string type;

        public void createCandy()
        {
            type = "Banana";
        }

        public string getLocation()
        {
            return locationX.ToString() + locationY.ToString();
        }
    }
}
