using System;
using TechTalk.SpecFlow;
using BPCalculator;
using FluentAssertions;

namespace SpecFlowTest.Features
{
    [Binding]
    public class BPCalculaterSteps
    {
        private readonly BloodPressure bp = new BloodPressure();
        int _result;
        string errorMessage = "";

        [Given(@"Systolic User Input is (.*)")]
        public void GivenSystolicUserInputIs(int p0)
        {
            //ScenarioContext.Current.Pending();
            bp.Systolic = p0;
        }
        
        [Given(@"Diastolic User Input is (.*)")]
        public void GivenDiastolicUserInputIs(int p0)
        {
            //ScenarioContext.Current.Pending();
            bp.Diastolic = p0;
        }
        
        [When(@"the blood pressure is calculated")]
        public void WhenTheBloodPressureIsCalculated()
        {
            //ScenarioContext.Current.Pending();
            _result = (bp.Systolic / 3) + (bp.Diastolic / 3) * 2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            //ScenarioContext.Current.Pending();
            p0.Should().Be(_result);
            errorMessage = "Invalid input";
        }
    }
}
