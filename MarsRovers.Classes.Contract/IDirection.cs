namespace MarsRovers.Classes.Contract
{
    /// <summary>
    /// Representing the direction of rover.
    /// </summary>
    /// <Author>Niu Yuan</Author>
    /// <Version>7/3/2018</Version>
    public interface IDirection
    {
        /// <summary>
        /// Name of direction representing by a single char: N, E, S, W
        /// </summary>
        char DName { get; }

        /// <summary>
        /// X vector for this direction
        /// </summary>
        int X { get; }

        /// <summary>
        /// Y vector for this direction
        /// </summary>
        int Y { get; }

        /// <summary>
        /// Rotate this direction, cycle through the direction name array.
        /// </summary>
        /// <param name="rotateIndex"></param>
        /// <returns></returns>
        IDirection Rotate(int rotateIndex);
    }
}
