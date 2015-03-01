using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTest
{
    [TestClass]
    public class I_NodeTest : NodeTestBase<I_Node>
    {
        [TestMethod]
        public void CanRepeat()
        {
            var node = new I_Node();
            node.Repetation = 2;
            Assert.IsTrue(node.CanRepeat());
            node.Repetation = 4;
            Assert.IsFalse(node.CanRepeat());
        }

        public new void SubtractFromV()
        {
            Assert.IsTrue(Node.Subtract(new VNode()) == 4);
        }

        public new void SubtractFromX()
        {
            Assert.IsTrue(Node.Subtract(new XNode()) == 9);
        }
    }
}
