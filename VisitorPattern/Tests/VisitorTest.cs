using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPattern;
namespace Tests
{
    [TestClass]
    public class VisitorTest
    {

        Chicken chicken = new Chicken();
        OvenVisitor ovenVisitor = new OvenVisitor();

        PanVisitor panVisitor = new PanVisitor();
        Beef beef = new Beef();
        [TestMethod]
        public void Test_Oven_Visiting_Chicken()
        {
           

            string result = chicken.Acccept(ovenVisitor);

            Assert.AreEqual(result, "The CHICKEN meat is being prepared in the OVEN");
        }
        [TestMethod]
        public void Test_Oven_Visiting_Beef()
        {

            string result = beef.Acccept(ovenVisitor);

            Assert.AreEqual(result, "The BEEF meat is being prepared in the OVEN");
        }
        [TestMethod]
        public void Test_Pan_Visiting_Chicken()
        {
            string result = chicken.Acccept(panVisitor);

            Assert.AreEqual(result, "The CHICKEN meat is being prepared in the PAN");
        }
        [TestMethod]
        public void Test_Pan_Visiting_Beef()
        {
            string result = beef.Acccept(panVisitor);

            Assert.AreEqual(result, "The BEEF meat is being prepared in the PAN");
        }
    }
}
