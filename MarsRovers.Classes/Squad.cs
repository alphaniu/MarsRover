using System.Collections.Generic;
using MarsRovers.Classes.Contract;

namespace MarsRovers.Classes
{
    /// <summary>
    /// See ISquad for description
    /// </summary>
    internal class Squad : ISquad
    {
        /// <summary>
        /// The list of rovers in the squad, only getter
        /// </summary>
        public IList<IRover> Rovers { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Squad()
        {
            Rovers = new List<IRover>();
        }

        /// <summary>
        /// Deploy a new rover, add it to this squad
        /// </summary>
        public IRover DeployNew(int xCoord, int yCoord, char dName)
        {
            IRover rover = new Rover(xCoord, yCoord, dName);
            Rovers.Add(rover);

            return rover;
        }
    }
}
