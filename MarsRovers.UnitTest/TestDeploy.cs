using MarsRovers.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.UnitTest
{
    [TestClass]
    public class TestDeploy
    {
        ///---------------- Test deploy -------------------

        /// <summary>
        /// Deploy two rovers without moving them
        /// </summary>
        [TestMethod]
        public void TestDeploySuccess()
        {
            var controller = new Controller();

            var input =
@"5 5
1 2 N
LR
2 3 W
LR";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"1 2 N
2 3 W";

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Deploy two rovers with first one out of bound, it will be lost.
        /// Output result only has second rover.
        /// </summary>
        [TestMethod]
        public void TestDeployOutOfBound()
        {
            var controller = new Controller();

            var input =
@"5 5
6 2 N
LR
2 3 W
LR";

            controller.Input(input);
            var actual = controller.Output().Trim();

            var expected =
@"2 3 W";

            Assert.AreEqual(expected, actual);
        }
    }
}