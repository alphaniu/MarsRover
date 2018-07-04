using MarsRovers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.UnitTest
{
    [TestClass]
    public class TestAll
    {

        ///---------------- Test comprehensive input -------------------

        /// <summary>
        /// Sample input from the code test pdf
        /// </summary>
        [TestMethod]
        public void TestSampleInput()
        {
            var controller = new Controller();

            var input = 
@"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 3 N
5 1 E";

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Custom input with 4 rovers
        /// </summary>
        [TestMethod]
        public void TestCustomInput()
        {
            var controller = new Controller();

            var input =
@"5 5
1 2 N
LMLMLMMM
3 3 E
MMRMMRMRRM
1 1 W
MMMMMM
0 0 N
MMMMMMMRMMMMMMM
6 6 N
LLLLL";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"3 1 E
5 1 E
0 1 W
5 5 E";

            Assert.AreEqual(expected, actual);
        }
        
    }
}
