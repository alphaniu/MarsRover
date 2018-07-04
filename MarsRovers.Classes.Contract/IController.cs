namespace MarsRovers.Classes.Contract
{
    /// <summary>
    /// Controller takes user input for rovers, execute the commands, and output the results.
    /// </summary>
    /// <Author>Niu Yuan</Author>
    /// <Version>7/3/2018</Version>
    public interface IController
    {
        /// <summary>
        /// Input with dimension, rover starting info, and commands.
        /// Then it deploy and execute commands for each rover.
        /// It will stop executing when an exception is thrown.
        /// </summary>
        /// <param name="input">input string</param>
        void Input(string input);

        /// <summary>
        /// Output the position and direction info for each rover as string.
        /// </summary>
        /// <returns>Rover position and direction</returns>
        string Output();
    }
}