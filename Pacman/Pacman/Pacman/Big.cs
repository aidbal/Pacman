using System;
namespace Pacman
{
    public class Big : ICandy
    {
        int locationX;
        int locationY;
        string type;

        public void createCandy()
        {
            type = "Big";
        }

        public string getLocation()
        {
            return locationX.ToString() + locationY.ToString();
        }
    }
}
