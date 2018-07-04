using MarsRovers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.UnitTest
{
    /// <summary>
    /// Summary description for TestRotate
    /// </summary>
    [TestClass]
    public class TestRotate
    {
        ///---------------- Test rotate left -------------------

        /// <summary>
        /// Deployed facing North, rotate left to West
        /// </summary>
        [TestMethod]
        public void TestRotateLeftN()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 N
L";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 W";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Deployed facing West, rotate left to South
        /// </summary>
        [TestMethod]
        public void TestRotateLeftW()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 W
L";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 S";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Deployed facing South, rotate left to East
        /// </summary>
        [TestMethod]
        public void TestRotateLeftS()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 S
L";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 E";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Deployed facing East, rotate left to North
        /// </summary>
        [TestMethod]
        public void TestRotateLeftE()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 E
L";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 N";

            Assert.AreEqual(expected, actual);
        }

        ///---------------- Test rotate right -------------------

        /// <summary>
        /// Deployed facing North, rotate right to East
        /// </summary>
        [TestMethod]
        public void TestRotateRightN()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 N
R";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 E";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Deployed facing West, rotate right to North
        /// </summary>
        [TestMethod]
        public void TestRotateRightW()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 W
R";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 N";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Deployed facing South, rotate right to West
        /// </summary>
        [TestMethod]
        public void TestRotateRightS()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 S
R";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 W";

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Deployed facing East, rotate right to South
        /// </summary>
        [TestMethod]
        public void TestRotateRightE()
        {
            var controller = new Controller();

            var input =
@"3 3
1 2 E
R";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 S";

            Assert.AreEqual(expected, actual);
        }
    }
}
