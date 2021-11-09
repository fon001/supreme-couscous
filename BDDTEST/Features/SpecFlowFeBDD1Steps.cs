using System;
using TechTalk.SpecFlow;
using BPCalculator;
using FluentAssertions;

namespace BDDTEST.Features
{
    [Binding]
    public class SpecFlowFeBDD1Steps
    {
        private BloodPressure bp = new BloodPressure();
        int _Systolic;
        int _Diastolic;

        [Given(@"Systolic User Input is (.*)")]
        public void GivenSystolicUserInputIs(int p0)
        {
            _Systolic = p0;
        }
        
        [Given(@"Diastolic User Input is (.*)")]
        public void GivenDiastolicUserInputIs(int p0)
        {
            _Diastolic = p0;
        }
        
        [When(@"the blood pressure is calculated")]
        public void WhenTheBloodPressureIsCalculated()
        {
            bp = new() { Systolic = _Systolic, Diastolic = _Diastolic };
        }
        
        [Then(@"the result should be low")]
        public void ThenTheResultShouldBeLow()
        {
            bp.Category.Should().Be(BPCategory.Low);
        }
        
        [Then(@"the result should be Ideal")]
        public void ThenTheResultShouldBeIdeal()
        {
            bp.Category.Should().Be(BPCategory.Ideal);
        }
        
        [Then(@"the result should be Pre-High")]
        public void ThenTheResultShouldBePre_High()
        {
            bp.Category.Should().Be(BPCategory.PreHigh);
        }
        
        [Then(@"the result should be High")]
        public void ThenTheResultShouldBeHigh()
        {
            bp.Category.Should().Be(BPCategory.High);
        }
    }
}
