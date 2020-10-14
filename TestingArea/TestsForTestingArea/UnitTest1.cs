using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingArea;

namespace TestsForTestingArea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 t = new Class1();

            Assert.IsTrue(t.match("0x123FB"));
        }
    }
}
