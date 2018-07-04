namespace MarsRovers.Classes.Contract
{
    /// <summary>
    /// Representing the plateau the rover squad will be deployed to
    /// </summary>
    /// <Author>Niu Yuan</Author>
    /// <Version>7/3/2018</Version>
    public interface IPlateau
    {
        /// <summary>
        /// Check if this coordinate is out of bound
        /// </summary>
        /// <param name="x">source x coordinate</param>
        /// <param name="y">source y coordinate</param>
        /// <returns></returns>
        bool OutOfBound(int x, int y);
    }
}