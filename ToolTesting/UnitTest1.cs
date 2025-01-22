using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _2025_01_22;

namespace ToolTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hammer hammer = new Hammer("kő kalapács", "kő", "fa");
            string expected = $"E kalapács neve {hammer.Type}.";
            Assert.AreEqual(expected, hammer.GetName());
        }
    }
}
