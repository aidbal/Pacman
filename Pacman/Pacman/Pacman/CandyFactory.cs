using System;
namespace Pacman
{
    public class CandyFactory
    {
        public CandyFactory()
        {
            public Candy createCandy(String newCandyType)
            {
                Candy newCandy = null;
                if (newCandyType.Equals("Banana"))
                {
                    return new Banana();
                }
                else if (newCandyType.Equals("Big"))
                {
                    return new Big();
                }
                else if (newCandyType.Equals("Cherry"))
                {
                    return new Cherry();
                }
                else if (newCandyType.Equals("Small"))
                {
                    return new Small();
                }
            }
        }
    }
}

