using System;

namespace RoverOnMars_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MarsSurface surface = new MarsSurface();
            Rover rover = new Rover();
            UserInput userInput = new UserInput();
            Checks check = new Checks();
            Logger logger = new Logger();

            string path = logger.GetCurrentDirectory();
            logger.CreateTxtFile(path);


            surface.DisplayRoverOnMars(rover.position, rover.direction);
            check.CheckBoundary(rover.PossiblePosition(rover.direction));
            Console.WriteLine();

            while (true)
            {
                string[] inputFromUser = userInput.GetUserInput();

                string userAction = userInput.OptionFromInput(inputFromUser);
                string userActionEffects = userInput.ActionFromInput(inputFromUser);

                if (userAction == "move")
                {
                    int[] newPosition = userInput.IntFromStringInput(userActionEffects);

                    if (check.CheckPositionCompatibility(newPosition, rover.PossiblePosition(rover.direction)) == true)
                    {
                        surface.CleanPreviousRoverPosition(rover.position);
                        rover.ChangeRoverPosition(newPosition);
                        check.CheckBoundary(rover.PossiblePosition(rover.direction));
                    }
                    else
                    {
                        Console.WriteLine("Your position does not match the allowed rover movement");
                    }
                }
                else if (userAction == "changeorientation")
                {
                    string arrowDirection = userInput.DirectionFromInput(userActionEffects);
                    rover.ChangeRoverDirection(arrowDirection);
                    check.CheckBoundary(rover.PossiblePosition(arrowDirection));
                }

                surface.DisplayRoverOnMars(rover.position, rover.direction);
                Console.WriteLine();
                logger.WriteToFile(path, userAction, userActionEffects, rover.direction);
            }
        }
    }
}
