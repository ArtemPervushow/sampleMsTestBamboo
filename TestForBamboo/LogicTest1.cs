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
            Assert.IsTrue(logic.aIsa(null));            Assert.IsTrue(logic.aIsa(0));            Assert.IsTrue(logic.aIsa("a"));            Assert.IsTrue(logic.aIsa(true));
        }

        [TestMethod]        public void SuccessChainOnEquality()        {            Assert.IsTrue(logic.chainOnEquality(0, 0, 0));            Assert.IsTrue(logic.chainOnEquality("a", "a", "a"));            Assert.IsTrue(logic.chainOnEquality(true, true, true));            Assert.IsFalse(logic.chainOnEquality(null, null, null));            Assert.IsFalse(logic.chainOnEquality(0, 0, "a"));            Assert.IsFalse(logic.chainOnEquality(0, "a", "a"));        }        [TestMethod]        public void SuccessAIsB()        {            Assert.IsTrue(logic.aIsB(0, 0));            Assert.IsTrue(logic.aIsB("a", "a"));            Assert.IsTrue(logic.aIsB(true, true));            Assert.IsFalse(logic.aIsB(null, null));            Assert.IsFalse(logic.aIsB(0, "a"));            Assert.IsFalse(logic.aIsB(0, true));            Assert.IsFalse(logic.aIsB("true", true));            Assert.IsFalse(logic.aIsB(false, true));
        }
    }
}
