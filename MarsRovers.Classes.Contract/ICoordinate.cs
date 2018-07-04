namespace MarsRovers.Classes.Contract
{
    /// <summary>
    /// Representing the coordinate of a rover
    /// </summary>
    /// <Author>Niu Yuan</Author>
    /// <Version>7/3/2018</Version>
    public interface ICoordinate
    {
        /// <summary>
        /// X coordinate
        /// </summary>
        int X { get; }

        /// <summary>
        /// Y coordinate
        /// </summary>
        int Y { get; }
    }
}
