using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestForBamboo
{
    [TestClass]
    public class LogicTest1
    {
        private static Logic logic;

        [ClassInitialize]
        public static void initLogic()
        {
            logic = new Logic();
        }

        [TestMethod]
        public void SuccessAIsa()
        {
            Assert.IsTrue(logic.aIsa(null));
        }

        [TestMethod]
        }
    }
}