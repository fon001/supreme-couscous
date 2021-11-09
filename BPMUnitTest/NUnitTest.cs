using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;
using System;


namespace BPMUnitTest
{
    
    [TestClass]
    public class NUnitTest
    {
        
        [TestMethod]
        public void TestLow()
        {
            
            BloodPressure bp = new BloodPressure() { Systolic = 85, Diastolic = 55 };
            Assert.AreEqual(BPCategory.Low, bp.Category);
        }

        [TestMethod]
        public void TestIdeal()
        {

            BloodPressure bp = new BloodPressure() { Systolic = 95, Diastolic = 75 };
            Assert.AreEqual(BPCategory.Ideal, bp.Category);
        }

        [TestMethod]
        public void TestPreHigh()
        {

            BloodPressure bp = new BloodPressure() { Systolic = 125, Diastolic = 85 };
            Assert.AreEqual(BPCategory.PreHigh, bp.Category);
        }

        [TestMethod]
        public void TestHigh()
        {

            BloodPressure bp = new BloodPressure() { Systolic = 145, Diastolic = 95 };
            Assert.AreEqual(BPCategory.High, bp.Category);
        }
    }
}
