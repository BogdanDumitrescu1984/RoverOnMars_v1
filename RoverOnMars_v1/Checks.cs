using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RoverOnMars_v1
{
    internal class Checks
    {
     
        public bool CheckPositionCompatibility(int[] userInput, int[] posPosition)
        {
            bool compatibilityValue = false;
            if (userInput[0] == posPosition[0] && userInput[1] == posPosition[1])
            {
                compatibilityValue = true;
            }

            return compatibilityValue;
        }

        public void CheckBoundary(int[] userInputPos)
        {
            if(userInputPos[0] < 0 || userInputPos[0] > 14 || userInputPos[1] <0 || userInputPos[1] > 14)
            {
                Console.WriteLine("You can only go beyond the boundary, change the direction!");
            }
            else
            {
                Console.WriteLine("Your next possible position is (" + userInputPos[0] + ", " + userInputPos[1] + ").");
            }
        }
    }
}
