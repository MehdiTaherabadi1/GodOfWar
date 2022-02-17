using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace UOM.Tests.Acceptance
{
    [Binding]
    public class ManagingDimensionsSteps
    {
        private string _dimension = "test";
        [Given(@"I have a dimension called '(.*)'")]
        public void GivenIHaveADimensionCalled(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have already defined a dimension called '(.*)'")]
        public void GivenIHaveAlreadyDefinedADimensionCalled(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I register the dimension")]
        public void WhenIRegisterTheDimension()
        {
            //TODO : refactor and complicate these task   
            var dimension = new { Name = this._dimension };
            var restClient = new RestClient("http://localhost:2000/api");
            var restRequest = new RestRequest("Dimensions", Method.Post);
            restRequest.AddObject(dimension);
            var result = restClient.ExecutePostAsync(restRequest);
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
