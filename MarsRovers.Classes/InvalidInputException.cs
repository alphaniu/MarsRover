using System;

namespace MarsRovers.Classes
{    
    /// <inheritdoc />
    /// <summary>
    /// Custom exception with message
    /// </summary>
    internal class InvalidInputException : Exception
    {
        internal InvalidInputException(string message) : base(message)
        {

        }
    }
}
