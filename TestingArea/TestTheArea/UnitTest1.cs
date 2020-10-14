using Microsoft.VisualStudio.TestPlatform;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestingArea;

namespace TestTheArea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {          

            int[] arr = { 1, 2 };

            Testing t = new Testing();

            t.Insert("cat", 0);

            Assert.AreEqual("cat", t.Get(0));


        }
    }
}
