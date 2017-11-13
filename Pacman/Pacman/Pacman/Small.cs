using System;
namespace Pacman
{
    public class Small : ICandy
    {
        int locationX;
        int locationY;
        string type;

        public void createCandy()
        {
            type = "Small";
        }

        public string getLocation()
        {
            return locationX.ToString() + locationY.ToString();
        }
    }
}
