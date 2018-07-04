using System;
using System.Linq;
using MarsRovers.Classes.Contract;

namespace MarsRovers.Classes
{
    /// <inheritdoc />
    /// <summary>
    /// See IController for description
    /// </summary>
    public class Controller : IController
    {
        // Private fields
        private IPlateau _plateau;
        private ISquad _squad;
        private char[] _commands;

        /// <summary>
        /// Input with dimension, rover starting info, and commands.
        /// Then it deploy and execute commands for each rover.
        /// It will stop executing when an exception is thrown.
        /// </summary>
        public void Input(string input)
        {
            //split the lines
            var lines = input.ToUpper().Trim().Split('\n');
            
            //first line for the plateau size
            var plateauLine = lines[0].Split(' ');

            //validate coordinate input
            if (plateauLine.Length != 2)
            {
                throw new InvalidInputException("Invalid input for coordinates");
            }

            var plateauX = ValidateCoordInput(plateauLine[0]);
            var plateauY = ValidateCoordInput(plateauLine[1]);

            //initialize the plateau and squad
            _plateau = new Plateau(plateauX, plateauY);
            _squad = new Squad();

            //begin to deploy rovers, read two lines at a time
            for (var i = 1; i < lines.Length; i = i + 2)
            {
                var roverLine = lines[i].Split(' ');

                //validate coordinate input format
                if (roverLine.Length != 3)
                {
                    throw new InvalidInputException("Invalid input format for deployment!");
                }
                var roverX = ValidateCoordInput(roverLine[0]);
                var roverY = ValidateCoordInput(roverLine[1]);
                var roverD = ValidateDirInput(roverLine[2][0]);

                //if a rover deployed out of plateau boundary, it's lost
                if (_plateau.OutOfBound(roverX, roverY))
                {
                    continue;
                }

                //deploy rover
                var rover = _squad.DeployNew(roverX, roverY, roverD);

                //read command letters
                if (lines[i + 1] != null)
                {
                    _commands = lines[i + 1].Trim().ToCharArray();
                }

                //execute commands for correct rover
                foreach (var command in _commands)
                {
                    ExecuteCommand(rover, command);
                }
            }
        }

        /// <summary>
        /// Output the position and direction info for each rover as string.
        /// </summary>
        public string Output()
        {
            var output = string.Empty;
            foreach (var rover in _squad.Rovers)
            {
                output += rover.GetPosition().X + " " + rover.GetPosition().Y + " " +
                          rover.GetDir().DName + "\r\n";
            }

            return output;
        }

        /// <summary>
        /// Coordinate input has to be non-negative integers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int ValidateCoordInput(string input)
        {
            try
            {
                var coordinate = Convert.ToInt32(input);
                if (coordinate < 0)
                {
                    throw new InvalidInputException(input + " is not a valid input for coordinate!");
                }
                return coordinate;
            }
            catch (Exception)
            {
                throw new InvalidInputException(input + " is not a valid input for coordinate!");
            }
        }

        /// <summary>
        /// Direction input has to be one of the: { 'N', 'E', 'S', 'W' }
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static char ValidateDirInput(char input)
        {
            char[] dNameArray = { 'N', 'E', 'S', 'W' };
            if (!dNameArray.Contains(input))
            {
                throw new InvalidInputException(input + " is not a valid input for direction!");
            }

            return input;
        }

        /// <summary>
        /// Execute command if its one of the { 'L', 'R', 'M' }
        /// Rover will not move further if it hit the boundary
        /// </summary>
        /// <param name="rover"></param>
        /// <param name="command"></param>
        private void ExecuteCommand(IRover rover, char command)
        {
            switch (command)
            {
                case 'L':
                    rover.RotateLeft();
                    break;
                case 'R':
                    rover.RotateRight();
                    break;
                case 'M':
                    if (!_plateau.OutOfBound(rover.GetDest().X, rover.GetDest().Y))
                    {
                        rover.Move();
                    }
                    break;
                default:
                    throw new InvalidInputException(command + " is not valid input for command!");
            }
        }
    }
}
