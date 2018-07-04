using MarsRovers.Classes.Contract;

namespace MarsRovers.Classes
{
    /// <inheritdoc />
    /// <summary>
    /// See IPlateau for description
    /// </summary>
    internal class Plateau : IPlateau
    {
        private readonly int _right;
        private readonly int _top;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="right"></param>
        /// <param name="top"></param>
        public Plateau(int right, int top)
        {
            _right = right;
            _top = top;
        }

        /// <summary>
        /// Check if this coordinate is out of bound
        /// </summary>
        public bool OutOfBound(int x, int y)
        {
            return x > _right || y > _top || x < 0 || y < 0;
        }
    }
}
