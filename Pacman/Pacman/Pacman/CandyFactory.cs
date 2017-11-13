using System;
using System.Collections.Generic;

namespace Pacman
{
    public class CandyFactory
    {

        List<ICandy> candies;
        public ICandy createCandy(String newCandyType)
        {
            ICandy newCandy = null;
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

