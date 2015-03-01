using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTest
{
    [TestClass]
    public class LNodeTest : NodeTestBase<LNode>
    {
        [TestMethod]
        public void CanRepeat()
        {
            var node = new LNode();
            node.Repetation = 2;
            Assert.IsFalse(node.CanRepeat());
        }
    }
}
