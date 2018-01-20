using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesTest1
{
    [TestClass]
    public class Classes
    {
        [TestMethod]
        public void ValueTypesTests()
        {
            int a = 5;
            int b = a;
            a = 2;
            Assert.AreEqual(2, a);
            Assert.AreEqual(5, b);

        }

        [TestMethod]
        public void ReferenceTypesTests()
        {
            string a = "something";
            string b = a;
            a = "nothing";
            Assert.AreEqual("nothing", a);
            Assert.AreEqual("something", b);
        }
    }
}
