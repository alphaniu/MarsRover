using MarsRovers.Classes.Contract;
using System;

namespace MarsRovers.Classes
{
    /// <inheritdoc />
    /// <summary>
    /// See IDirection for description
    /// </summary>
    internal class Direction : IDirection
    {
        // Public properties
        public char DName { get; }
        public int X { get; }
        public int Y { get; }

        private static readonly char[] DNameArray = { 'N', 'E', 'S', 'W' };

        /// <summary>
        /// Constructor for the current direction based on direction name
        /// </summary>
        /// <param name="dName"></param>
        public Direction(char dName)
        {
            DName = dName;

            switch (dName)
            {
                case 'N':
                    X = 0;
                    Y = 1;
                    break;
                case 'E':
                    X = 1;
                    Y = 0;
                    break;
                case 'S':
                    X = 0;
                    Y = -1;
                    break;
                case 'W':
                    X = -1;
                    Y = 0;
                    break;
                default:
                    throw new InvalidInputException(dName + " is not a valid input for direction!");
            }
        }

        /// <summary>
        /// Rotate this direction, cycle through the direction name array.
        /// </summary>
        /// <param name="rotateIndex"></param>
        /// <returns></returns>
        public IDirection Rotate(int rotateIndex)
        {
            var currentIndex = Array.IndexOf(DNameArray, DName);
            currentIndex = (currentIndex + rotateIndex + 4) % 4;

            return new Direction(DNameArray[currentIndex]);
        }
    }
}
