﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter;

namespace NumberConverterTest
{
    [TestClass]
    public class VNodeTest : NodeTestBase<VNode>
    {
        [TestMethod]
        public void CanRepeat()
        {
            var node = new VNode();
            node.Repetation = 2;
            Assert.IsFalse(node.CanRepeat());
        }
    }
}
