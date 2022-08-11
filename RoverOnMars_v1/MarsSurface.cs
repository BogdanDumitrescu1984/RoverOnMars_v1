using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars_v1
{
    internal class MarsSurface
    {
        public string[,] marsSurface = new string[15, 15] {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            };

        public void DisplayMars()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(marsSurface[i, j]);
                    if (j == 14)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        public void PutRoverOnMars(int[] position, string direction) //add code to block from allowing to go beyond
        {
            marsSurface[position[0], position[1]] = direction;
        }

        public void CleanPreviousRoverPosition(int[] position)
        {
            marsSurface[position[0], position[1]] = "o";
        }

        public void DisplayRoverOnMars(int[] position, string direction)
        {
            PutRoverOnMars(position, direction);
            DisplayMars();
        }

    }
}
