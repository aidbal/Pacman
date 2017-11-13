using System;
namespace Pacman
{
    public class Cherry : ICandy
    {
        int locationX;
        int locationY;
        string type;

        public void createCandy()
        {
            type = "Cherry";
        }

        public string getLocation()
        {
            return locationX.ToString() + locationY.ToString();
        }
    }
}
