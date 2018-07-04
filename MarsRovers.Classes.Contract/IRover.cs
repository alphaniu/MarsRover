namespace MarsRovers.Classes.Contract
{
    /// <summary>
    /// Representing a rover with its properties and actions.
    /// </summary>
    /// <Author>Niu Yuan</Author>
    /// <Version>7/3/2018</Version>
    public interface IRover
    {
        /// <summary>
        /// Move one coordinate in the current direction
        /// </summary>
        /// <returns>The new coordinate</returns>
        ICoordinate Move();

        /// <summary>
        /// Roate left by 90 degree
        /// </summary>
        /// <returns>The new direction</returns>
        IDirection RotateLeft();

        /// <summary>
        /// Roate right by 90 degree
        /// </summary>
        /// <returns>The new direction</returns>
        IDirection RotateRight();

        /// <summary>
        /// Get the current coordinate of the rover
        /// </summary>
        /// <returns>The current coordinate</returns>
        ICoordinate GetPosition();

        /// <summary>
        /// Get the current direction of the rover
        /// </summary>
        /// <returns>The current direction</returns>
        IDirection GetDir();

        /// <summary>
        /// Get where it will be if Move command is executed
        /// </summary>
        /// <returns>The new position</returns>
        ICoordinate GetDest();
    }
}