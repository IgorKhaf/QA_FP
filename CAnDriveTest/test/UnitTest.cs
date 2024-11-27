using CanDrive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanDriveTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             Assert.AreEqual(false, DrivingChecker.CanDrive(int.MinValue));
        }

        [TestMethod]
        public void TestMethod2()
        {
             Assert.AreEqual(false, DrivingChecker.CanDrive(int.MinValue+1));
        }

        [TestMethod]
        public void TestMethod3()
        {
             Assert.AreEqual(false, DrivingChecker.CanDrive(-1));
        }

        [TestMethod]
        public void TestMethod4()
        {
             Assert.AreEqual(false, DrivingChecker.CanDrive(0));
        }

        [TestMethod]
        public void TestMethod5()
        {
             Assert.AreEqual(false, DrivingChecker.CanDrive(1));
        }

        [TestMethod]
        public void TestMethod6()
        {
             Assert.AreEqual(false, DrivingChecker.CanDrive(15));
        }

        [TestMethod]
        public void TestMethod7()
        {
             Assert.AreEqual(true, DrivingChecker.CanDrive(16));
        }

        [TestMethod]
        public void TestMethod8()
        {
             Assert.AreEqual(true, DrivingChecker.CanDrive(17));
        }
        [TestMethod]
        public void TestMethod9()
        {
             Assert.AreEqual(true, DrivingChecker.CanDrive(int.MaxValue-1));
        }
        [TestMethod]
        public void TestMethod10()
        {
             Assert.AreEqual(true, DrivingChecker.CanDrive(int.MaxValue));
        }
    }
}