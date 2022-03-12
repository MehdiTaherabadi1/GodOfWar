using System;
using RestSharp;
using TechTalk.SpecFlow;
using UOM.Tests.Acceptance.Model;
using UOM.Tests.Acceptance.Tasks;

namespace UOM.Tests.Acceptance
{
    [Binding]
    public class ManagingDimensionsSteps
    {
        private string _dimension = "test";
        [Given(@"I have a dimension called '(.*)'")]
        public void GivenIHaveADimensionCalled(string p0)
        {
            var dimension = new DimensionTestModel() { Name = p0 };
            ScenarioContext.Current.Add("dimension", dimension);
        }

        [Given(@"I have already defined a dimension called '(.*)'")]
        public void GivenIHaveAlreadyDefinedADimensionCalled(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I register the dimension")]
        public void WhenIRegisterTheDimension()
        {
            var model = ScenarioContext.Current.Get<DimensionTestModel>("dimension" +
                "");
            var taskDimension = new DimensionTask();
            taskDimension.DefineDimension(model);
        }

        [Then(@"It should be appear in the list of  dimensions")]
        public void ThenItShouldBeAppearInTheListOfDimensions()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The system should prevent me from registering the dimension")]
        public void ThenTheSystemShouldPreventMeFromRegisteringTheDimension()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"It should warned that the dimension is duplicated")]
        public void ThenItShouldWarnedThatTheDimensionIsDuplicated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
