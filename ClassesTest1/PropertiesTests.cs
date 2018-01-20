using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesTest1
{
     class Properties
     {
        private int _age; //field

        public int Age {
            get { return _age; }
            set {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age can't be negative " + value);
                }
            } 
        } //property

        public int Age2 { get; set; }

        public int Height { get; set; }
    }

    [TestClass]
    public class PropertiesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Properties prop = new Properties();
            prop.Age = 140;
            Assert.AreEqual(140, prop.Age);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Method should throw exception")]
        public void TestNegative()
        {
            Properties prop = new Properties();
            prop.Age = -8;
           
        }
    }
}
