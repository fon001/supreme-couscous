using System;
using TechTalk.SpecFlow;
using BPCalculator;
using FluentAssertions;

namespace BDDTEST.Features
{
    [Binding]
    public class SpecFlowFeBDD1Steps
    {
        private BloodPressure bloodpressure = new BloodPressure();
        int _Systolic;
        int _Diastolic;

        [Given(@"Systolic User Input is (.*)")]
        public void GivenSystolicUserInputIs(int p0)
        {
            //
        }
        
        [Given(@"Diastolic User Input is (.*)")]
        public void GivenDiastolicUserInputIs(int p0)
        {
            //
        }
        
        [When(@"the blood pressure is calculated")]
        public void WhenTheBloodPressureIsCalculated()
        {
            //
        }
        
        [Then(@"the result should be low")]
        public void ThenTheResultShouldBeLow()
        {
            //
        }
        
        [Then(@"the result should be Ideal")]
        public void ThenTheResultShouldBeIdeal()
        {
            //
        }
        
        [Then(@"the result should be Pre-High")]
        public void ThenTheResultShouldBePre_High()
        {
            //
        }
        
        [Then(@"the result should be High")]
        public void ThenTheResultShouldBeHigh()
        {
            //
        }
    }
}
