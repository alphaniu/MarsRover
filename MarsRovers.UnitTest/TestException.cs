using System;
using MarsRovers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.UnitTest
{
    [TestClass]
    public class TestException
    {
        ///---------------- Test exception handling -------------------

        /// <summary>
        /// First rover is valid, second rover has invalid input.
        /// Deliberately catch the exception thrown by the next rover.
        /// Output only has the reuslt of the first rover.
        /// </summary>
        [TestMethod]
        public void TestInvalidSecondRover()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 W
LM
1 A
MMLLRR";

            try
            {
                controller.Input(input);
            }
            catch (InvalidInputException)
            {

            }

            var actual = controller.Output().Trim();

            var expected =
@"1 1 S";

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Exception: Empty input
        /// </summary>
        [TestMethod]
        public void TestExceptionEmptyInput()
        {
            var controller = new Controller();

            var input = "";

            try
            {
                controller.Input(input);
            }
            catch (InvalidInputException e)
            {
                Assert.AreEqual("Invalid input for coordinates", e.Message);
            }
        }

        /// <summary>
        /// Exception: Invalid plateau dimension
        /// </summary>
        [TestMethod]
        public void TestExceptionInvalidPlateau()
        {
            var controller = new Controller();

            var input =
@"-3 3
1 2 W
LM";
            
            try
            {
                controller.Input(input);
            }
            catch (InvalidInputException e)
            {
                Assert.AreEqual("-3 is not a valid input for coordinate!", e.Message);
            }
        }

        /// <summary>
        /// Exception: Invalid deploy coordinate
        /// </summary>
        [TestMethod]
        public void TestExceptionInvalidCoord()
        {
            var controller = new Controller();

            var input =
@"3 3
1 A W
LM";
            
            try
            {
                controller.Input(input);
            }
            catch (InvalidInputException e)
            {
                Assert.AreEqual("A is not a valid input for coordinate!", e.Message);
            }
        }

        /// <summary>
        /// Exception: Invalid deploy direction
        /// </summary>
        [TestMethod]
        public void TestExceptionInvalidDir()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 A
LM";

            try
            {
                controller.Input(input);
            }
            catch (InvalidInputException e)
            {
                Assert.AreEqual("A is not a valid input for direction!", e.Message);
            }
        }

        /// <summary>
        /// Exception: Invalid deploy input format
        /// </summary>
        [TestMethod]
        public void TestExceptionInvalidDeploy()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2
LM";

            try
            {
                controller.Input(input);
            }
            catch (InvalidInputException e)
            {
                Assert.AreEqual("Invalid input format for deployment!", e.Message);
            }
        }

        /// <summary>
        /// Exception: Invalid rover command
        /// </summary>
        [TestMethod]
        public void TestExceptionInvalidCom()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 W
LA";

            try
            {
                controller.Input(input);
            }
            catch (InvalidInputException e)
            {
                Assert.AreEqual("A is not valid input for command!", e.Message);
            }
        }
    }
}
