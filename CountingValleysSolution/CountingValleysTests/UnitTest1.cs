using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountingValleys;
using System;

namespace CountingValleysTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// A simple input for the method, should return 1, the number of valleys that was traversed
        /// </summary>
        [TestMethod]
        public void SimpleTest()
        {
            CountValleys t = new CountValleys();

            int result = t.countingValleys(8, "UDDDUDUU");

            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// Another basic input
        /// </summary>
        [TestMethod]
        public void SimpleTest2()
        {
            CountValleys t = new CountValleys();

            int result = t.countingValleys(8, "DUDUDUDU");
            Assert.AreEqual(4, result);
        }

        /// <summary>
        /// A test where we only go uphill from the start, should have 0 valley traversals
        /// </summary>
        [TestMethod]
        public void UphillClimbingOnly()
        {
            CountValleys t = new CountValleys();

            int result = t.countingValleys(8, "UUUUUUUU");
            Assert.AreEqual(0, result);
        }



    }
}
