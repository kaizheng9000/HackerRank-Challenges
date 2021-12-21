using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatedString;
using System;

namespace RepeatedStringTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicTest()
        {
            long repeat = 10;

            RepeatedStringSolution t = new RepeatedStringSolution();

            long result = t.SolveRepeatedString("a", repeat);

            Assert.AreEqual(repeat, result);

        }

        [TestMethod]
        public void BasicTest2()
        {
            RepeatedStringSolution t = new RepeatedStringSolution();

            long result = t.SolveRepeatedString("a", 1000000000000);

            Assert.AreEqual(1000000000000, result);

        }


        [TestMethod]
        public void BasicTest3()
        {
            long repeat = 11;

            RepeatedStringSolution t = new RepeatedStringSolution();

            long result = t.SolveRepeatedString("abcac", repeat);

            Assert.AreEqual(5, result);

        }


    }
}
