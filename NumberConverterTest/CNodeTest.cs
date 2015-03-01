using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTest
{
    [TestClass]
    public class CNodeTest : NodeTestBase<CNode>
    {
        [TestMethod]
        public void CanRepeat()
        {
            var node = new CNode();
            node.Repetation = 2;
            Assert.IsTrue(node.CanRepeat());
            node.Repetation = 4;
            Assert.IsFalse(node.CanRepeat());
        }

        [TestMethod]
        public new void SubtractFromM()
        {
            Assert.IsTrue(base.Subtract(new MNode()) == 900);
        }

        [TestMethod]
        public new void SubtractFromD()
        {
            Assert.IsTrue(base.Subtract(new DNode()) == 400);
        }
    }
}
