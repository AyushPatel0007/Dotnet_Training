using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unit_Testing_Demo;

namespace TestDemo
{
    [TestClass]
    public class UnitTest1
    {
        UnitTestDemo ut = new UnitTestDemo();
        [TestMethod]
        public void TestMethod1()
        { 
            int result1 = ut.add(1, 1);
            Assert.AreEqual(2, result1);
           
        }
        [TestMethod]
        public void TestMethod2()
        {
            string s = "helo";
            string r = "helo";
          Assert.AreEqual(s,r);

        }
    }
}
