using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter;

namespace NumberConverterTest
{
    public abstract class NodeTestBase<T> where T : NodeBase, new()
    {
        public T Node { get; private set; }

        protected NodeTestBase()
        {
            Node = new T();
        }

        public int Subtract(NodeBase from)
        {
            return Node.Subtract(from);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public virtual void SubtractFromV()
        {
            Subtract(new VNode());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public virtual void SubtractFromM()
        {
            Subtract(new MNode());
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public virtual void SubtractFromC()
        {
            Subtract(new CNode());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public virtual void SubtractFromL()
        {
            Subtract(new LNode());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public virtual void SubtractFromI()
        {
            Subtract(new I_Node());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public virtual  void SubtractFromX()
        {
            Subtract(new XNode());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSubtractionException))]
        public virtual void SubtractFromD()
        {
            Subtract(new DNode());
        }
    }
}
