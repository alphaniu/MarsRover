using System.Collections;
using System.Collections.Generic;

namespace MarsRovers.Classes.Contract
{
    /// <summary>
    /// Representing a list of rovers deployed in the plateau
    /// </summary>
    /// <Author>Niu Yuan</Author>
    /// <Version>7/3/2018</Version>
    public interface ISquad
    {
        /// <summary>
        /// The list of rovers in the squad, only getter
        /// </summary>
        IList<IRover> Rovers { get; }

        /// <summary>
        /// Deploy a new rover, add it to this squad
        /// </summary>
        /// <param name="xCoord">starting x coordinate</param>
        /// <param name="yCoord">starting y coordinate</param>
        /// <param name="dName">starting direction</param>
        /// <returns></returns>
        IRover DeployNew(int xCoord, int yCoord, char dName);
    }
}