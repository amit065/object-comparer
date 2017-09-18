using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer;

namespace Tests
{
    [TestClass]
    public class ComparerTest
    {
        [TestMethod]
        public void Test_For_Type_Compare()
        {
            Comparer compare = new Comparer();
            var result = compare.typeComapare();
            Assert.AreEqual(false,result);
        }

        [TestMethod]
        public void Test_For_Method_Compare()
        {
            Comparer compare = new Comparer();
            var result = compare.methodComapare();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_For_Properties_Compare()
        {
            Comparer compare = new Comparer();
            var result = compare.propertyComapare();
            Assert.AreEqual(false, result);
        }
    }

}
