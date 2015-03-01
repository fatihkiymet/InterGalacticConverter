using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter;

namespace NumberConverterTest
{
    [TestClass]
    public class DNodeTest : NodeTestBase<DNode>
    {
        [TestMethod]
        public void CanRepeat()
        {
            var node = new DNode {Repetation = 2};
            Assert.IsFalse(node.CanRepeat());
        }
    }
}
