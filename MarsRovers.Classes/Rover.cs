using MarsRovers.Classes.Contract;

namespace MarsRovers.Classes
{
    /// <summary>
    /// See IRover for description
    /// </summary>
    internal class Rover : IRover
    {
        // Private fields
        private ICoordinate _position;
        private IDirection _direction;
        private ICoordinate _destination; // where it will be if move command is executed

        /// <summary>
        /// Constructor for a new rover
        /// </summary>
        /// <param name="x">starting X coordinate</param>
        /// <param name="y">starting Y coordinate</param>
        /// <param name="dName">starting direction</param>
        public Rover(int x, int y, char dName)
        {
            _position = new Coordinate(x, y);
            _direction = new Direction(dName);
            _destination = new Coordinate(x + _direction.X, y + _direction.Y);
        }

        /// <summary>
        /// Move one coordinate in the current direction
        /// </summary>
        public ICoordinate Move()
        {
            // destination becomes position
            _position = _destination;

            // new destination
            _destination = new Coordinate(_position.X + _direction.X, _position.Y + _direction.Y);

            return _position;
        }

        /// <summary>
        /// Roate left by 90 degree
        /// </summary>
        public IDirection RotateLeft()
        {
            // cycle through direction name array
            _direction = _direction.Rotate(-1);

            // update destination
            _destination = new Coordinate(_position.X + _direction.X, _position.Y + _direction.Y);

            return _direction;
        }

        /// <summary>
        /// Roate right by 90 degree
        /// </summary>
        public IDirection RotateRight()
        {
            // cycle through direction name array
            _direction = _direction.Rotate(1);

            // update destination
            _destination = new Coordinate(_position.X + _direction.X, _position.Y + _direction.Y);

            return _direction;
        }

        /// <summary>
        /// Get the current coordinate of the rover
        /// </summary>
        public ICoordinate GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// Get the current direction of the rover
        /// </summary>
        public IDirection GetDir()
        {
            return _direction;
        }

        /// <summary>
        /// Get where it will be if Move command is executed
        /// </summary>
        public ICoordinate GetDest()
        {
            return _destination;
        }
    }
}
