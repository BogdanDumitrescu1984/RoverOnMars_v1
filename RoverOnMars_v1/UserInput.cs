using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RoverOnMars_v1
{
    internal class UserInput
    {
        public string[] directions = new string[4] { "→", "←", "↑", "↓" };
        string direction;
        public string DirectionFromInput(string userInput)
        {
            switch (userInput)
            {
                case "north":
                    direction = directions[2];
                    break;
                case "south":
                    direction = directions[3];
                    break;
                case "east":
                    direction = directions[0];
                    break;
                case "west":
                    direction = directions[1];
                    break;
                default:
                    break;
            }
            return direction;
        }

        public string[] GetUserInput() // client input rover -move x,y or rover -changeOrientation North
        {
            string input = Console.ReadLine();
            string[] splitUserInput = input.Split(" ");

            if (splitUserInput.Length == 3)
            {
                return splitUserInput;
            }
            else
            {
                Console.WriteLine("You have exited the game!");
                Environment.Exit(0);
            }

            return splitUserInput;
        }

        public string OptionFromInput(string[] tempUserOption)
        {
            string userOption = tempUserOption[1].ToLower().Substring(1, tempUserOption[1].Length-1);

            return userOption;
        }

        public string ActionFromInput(string[] tempUserOption)
        {
            string tempActionOption = tempUserOption[2].ToLower();

            return tempActionOption;
        }

        public int[] IntFromStringInput(string userPosInput)
        {
            int[] integerPosition = new int[2];
            string[] elems = userPosInput.Split(",");

            integerPosition[0] = Int16.Parse(elems[0]);
            integerPosition[1] = Int16.Parse(elems[1]);

            return integerPosition;
        }

    }
}
