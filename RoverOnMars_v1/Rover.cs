using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars_v1
{
    internal class Rover
    {
        public string direction;
        public int[] position = new int[2];
        public string[] directions = new string[4] { "→", "←", "↑", "↓" };



        Random rnd = new Random();
        public Dictionary<string, int[]> directionPositionDict = new Dictionary<string, int[]>();
        public Dictionary<string, int[]> AddToDict()
        {
            directionPositionDict.Add("→", new int[2] { 0, 1 });
            directionPositionDict.Add("←", new int[2] { 0, -1 });
            directionPositionDict.Add("↑", new int[2] { -1, 0 });
            directionPositionDict.Add("↓", new int[2] { 1, 0 });

            return directionPositionDict;
        }

        public Rover()
        {
            this.direction = directions[rnd.Next(0, 4)];
            this.position[0] = rnd.Next(0, 14);
            this.position[1] = rnd.Next(0, 14);
            this.directionPositionDict = AddToDict();
        }

        public void ChangeRoverPosition(int[] newPosition)
        {
            this.position[0] = newPosition[0];
            this.position[1] = newPosition[1];
        }

        public void ChangeRoverDirection(string direction)
        {
            this.direction = direction;
        }

        public int[] PossiblePosition(string direction)
        {
            Checks checks = new Checks();
            int[] possiblePosition = new int[2];

            foreach( string elem in this.directionPositionDict.Keys)
            {
                if (elem == direction)
                {
                    possiblePosition[0] = this.position[0] + this.directionPositionDict[elem][0];
                    possiblePosition[1] = this.position[1] + this.directionPositionDict[elem][1];
                }
            }

            return possiblePosition;

        }
    
    }
}
