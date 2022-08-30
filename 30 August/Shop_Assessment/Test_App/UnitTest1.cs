using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop_Assessment.Controllers;
using System;
using System.Web.Mvc;

namespace Test_App
{
    [TestClass]
    public class UnitTest1
    {
       
         
        [TestMethod]
        public void TestMethod2()
        {
            var h = new ShopController();
            var res = h.Index(1) as ViewResult;
            Assert.AreEqual<string>( "Index2", res.ViewName);

        }
        [TestMethod]
        public void TestMethod3()
        {
            var h = new ShopController();
            ViewResult res = h.Index(0) as ViewResult;
            Assert.AreEqual<string>("Index", res.ViewName);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            ShopController h = new ShopController();
            ViewResult res = h.Index2() as ViewResult;
            Assert.AreEqual<string>("Somevalue", res.ViewData["Some"].ToString());

        }


    }
}
