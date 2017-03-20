using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPattern;
namespace Tests
{
    [TestClass]
    public class VisitorTest
    {
        [TestMethod]
        public void Test_Oven_Visiting_Chicken()
        {
            Chicken chicken = new Chicken();

            OvenVisitor ovenVisitor = new OvenVisitor();
            string result = ovenVisitor.Visit(chicken);

            Assert.AreEqual(result, "The CHICKEN meat is being prepared in the OVEN");
        }
        [TestMethod]
        public void Test_Oven_Visiting_Beef()
        {
            Beef  beef = new Beef();

            OvenVisitor ovenVisitor = new OvenVisitor();
            string result = ovenVisitor.Visit(beef);

            Assert.AreEqual(result, "The BEEF meat is being prepared in the OVEN");
        }
        [TestMethod]
        public void Test_Pan_Visiting_Chicken()
        {
            Chicken chicken = new Chicken();

            PanVisitor panVisitor = new PanVisitor();
            string result = panVisitor.Visit(chicken);

            Assert.AreEqual(result, "The CHICKEN meat is being prepared in the PAN");
        }
        [TestMethod]
        public void Test_Pan_Visiting_Beef()
        {
            Beef beef = new Beef();

            PanVisitor panVisitor = new PanVisitor();
            string result = panVisitor.Visit(beef);

            Assert.AreEqual(result, "The BEEF meat is being prepared in the PAN");
        }
    }
}
