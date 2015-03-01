using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTest
{
    [TestClass]
    public class NodeParserTest
    {
        [TestMethod]
        public void Parse()
        {
            var parser = new NodeParser();

            var node1 = parser.Parse("XIX");
            var node2 = parser.Parse("DIVX");
            var node3 = parser.Parse("DIVXM");

            Assert.IsTrue(node1.Previous.Value == 1);
            Assert.IsTrue(node2.Previous.Previous.Previous.Value == (int)NodeType.D);
            Assert.IsNull(node2.Previous.Previous.Previous.Previous);
            Assert.IsTrue(node3.Value == (int)NodeType.M);

            try
            {
                parser.Parse("DIVfXM");
                Assert.Fail();
            }
            catch (ParseException ex)
            {
                
            }
            catch(Exception ex)
            {
                Assert.Fail();
            }

        }
    }
}
