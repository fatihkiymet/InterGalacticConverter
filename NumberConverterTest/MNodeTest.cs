using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTest
{
    [TestClass]
    public class MNodeTest : NodeTestBase<MNode>
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public void Subtract()
        {
            Node.Subtract(new I_Node());

        }


        [TestMethod]
        public void CanRepeat()
        {
            var node = new MNode();
            node.Repetation = 2;
            Assert.IsTrue(node.CanRepeat());
            node.Repetation = 4;
            Assert.IsFalse(node.CanRepeat());
        }
    }
}
