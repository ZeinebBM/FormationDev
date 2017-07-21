using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var resu = controller.BMI(1, 1);

            //Assert
            Assert.AreEqual(1,resu );
        }
    }
    
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            //  Arrange
            var controller = new ValuesController();

            // Act
            var resu = controller.BMI(2, 2);

            //Assert
            Assert.AreEqual(0.5, resu);
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var resu = controller.BMI(0, 1);

            //Assert
            Assert.AreEqual(0, resu);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var resu = controller.BMI(0, 1);

            //Assert
            Assert.AreEqual(0, resu);
        }
    }


}
