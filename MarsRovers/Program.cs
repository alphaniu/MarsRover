using MarsRovers.Classes;
using System;
using System.IO;
using MarsRovers.Classes.Contract;

namespace MarsRovers
{
    /// <summary>
    /// Test console program
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            IController controller = new Controller();

            Console.WriteLine("Input text file name:");
            var fileName = Console.ReadLine();

            try
            {
                var sr = new StreamReader(fileName);

                //get input string
                var input = sr.ReadToEnd();

                //process input
                Console.WriteLine("Input:\n" + input);
                controller.Input(input);

                //output result
                Console.WriteLine("\nOutput:\n" + controller.Output());
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                //display exception message
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
