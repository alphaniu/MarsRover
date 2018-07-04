using MarsRovers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.UnitTest
{
    [TestClass]
    public class TestMove
    {
        ///---------------- Test move -------------------

        /// <summary>
        /// Deployed facing East, move 2 times
        /// </summary>
        [TestMethod]
        public void TestMoveEast()
        {
            var controller = new Controller();

            var input =
@"3 3
1 0 E
MM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"3 0 E";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Deployed facing North, move 2 times
        /// </summary>
        [TestMethod]
        public void TestMoveNorth()
        {
            var controller = new Controller();

            var input =
@"3 3
1 0 N
MM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 N";

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Deployed facing West, move 2 times
        /// </summary>
        [TestMethod]
        public void TestMoveWest()
        {
            var controller = new Controller();

            var input =
@"3 3
2 2 W
MM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"0 2 W";

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Deployed facing West, move 2 times
        /// </summary>
        [TestMethod]
        public void TestMoveSouth()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 S
MM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 0 S";

            Assert.AreEqual(expected, actual);
        }

        ///---------------- Test hit boundary -------------------

        /// <summary>
        /// Will not move left any further when hit left boundary
        /// </summary>
        [TestMethod]
        public void TestHitLeftBoundary()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 N
LMMMMMMMM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"0 2 W";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Will not move up any further when hit top boundary
        /// </summary>
        [TestMethod]
        public void TestHitTopBoundary()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 W
RMMMMMMMM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 3 N";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Will not move right any further when hit right boundary
        /// </summary>
        [TestMethod]
        public void TestHitRightBoundary()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 N
RMMMMMMMM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"3 2 E";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Will not move down any further when hit bottom boundary
        /// </summary>
        [TestMethod]
        public void TestHitBottomBoundary()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 W
LMMMMMMMM";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 0 S";

            Assert.AreEqual(expected, actual);
        }
    }
}
