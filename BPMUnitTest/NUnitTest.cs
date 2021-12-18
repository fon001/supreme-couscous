using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;
using System;


namespace BPMUnitTest
{
    
    [TestClass]
    public class NUnitTest
    {
        
        [TestMethod]
        public void Low()
        {

            BloodPressure bloodPressure = new BloodPressure() { Systolic = 89, Diastolic = 59 };
            Assert.AreEqual(BPCategory.Low, bloodPressure.Category);
        }

        [TestMethod]
        public void Ideal()
        {

            BloodPressure bloodPressure = new BloodPressure() { Systolic = 120, Diastolic = 80 };
            Assert.AreEqual(BPCategory.Ideal, bloodPressure.Category);
        }

        [TestMethod]
        public void PreHigh()
        {

            BloodPressure bloodPressure = new BloodPressure() { Systolic = 140, Diastolic = 90 };
            Assert.AreEqual(BPCategory.PreHigh, bloodPressure.Category);
        }

        [TestMethod]
        public void High()
        {

            BloodPressure bloodPressure = new BloodPressure() { Systolic = 190, Diastolic = 100 };
            Assert.AreEqual(BPCategory.High, bloodPressure.Category);
        }
    }
}
