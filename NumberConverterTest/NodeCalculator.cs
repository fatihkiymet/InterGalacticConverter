using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;

namespace UnitConverterTest
{
    [TestClass]
    public class NodeCalculatorTest
    {        
        [TestMethod]
        public void CalculateTest()
        {
            var calculator = new NodeCalculator();
            Assert.IsTrue(calculator.Calculate("V") == 5);
            Assert.IsTrue(calculator.Calculate("VI") == 6);
            Assert.IsTrue(calculator.Calculate("VII") == 7);
            Assert.IsTrue(calculator.Calculate("VIII") == 8);
            Assert.IsTrue(calculator.Calculate("XIX") == 19);
            Assert.IsTrue(calculator.Calculate("IXIX") == 18);

            //repetition
            Assert.IsTrue(calculator.Calculate("MXXX") == 1030);

            //only one small value can be subtracted
            Assert.IsTrue(calculator.Calculate("MXXIIX") == 1030);

            //only one small value can be subtracted and V can never be subtracted
            Assert.IsTrue(calculator.Calculate("MXXVIX") == 1034);

            Assert.IsTrue(TestHelper.IsInvalidSubtraction(() => calculator.Calculate("VX")));
            Assert.IsTrue(TestHelper.IsParseException(() => calculator.Calculate("VsX")));
        }
    }
}
