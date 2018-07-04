using MarsRovers.Classes.Contract;

namespace MarsRovers.Classes
{
    /// <inheritdoc />
    /// <summary>
    /// See ICoordinate for description
    /// </summary>
    public class Coordinate : ICoordinate
    {
        /// <inheritdoc />
        /// Public properties
        public int X { get; }
        public int Y { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
