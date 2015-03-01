using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter;

namespace NumberConverterTest
{
    [TestClass]
    public class XNodeTest : NodeTestBase<XNode>
    {
        [TestMethod]
        public void CanRepeat()
        {
            var node = new XNode();
            node.Repetation = 2;
            Assert.IsTrue(node.CanRepeat());
            node.Repetation = 4;
            Assert.IsFalse(node.CanRepeat());
        }

        [TestMethod]
        public new void SubtractFromC()
        {
            Assert.IsTrue(Node.Subtract(new CNode()) == 90);
        }

        [TestMethod]
        public new void SubtractFromL()
        {
            Assert.IsTrue(Node.Subtract(new LNode()) == 40);
        }
    }
}
