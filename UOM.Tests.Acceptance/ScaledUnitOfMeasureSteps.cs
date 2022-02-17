using System;
using TechTalk.SpecFlow;

namespace UOM.Tests.Acceptance
{
    [Binding]
    public class ScaledUnitOfMeasureSteps
    {
        [Given(@"I Have already difind a scaled uom called '(.*)' as following")]
        public void GivenIHaveAlreadyDifindAScaledUomCalledAsFollowing(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I convert '(.*)' '(.*)' to '(.*)'")]
        public void WhenIConvertTo(int p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The result  should be '(.*)' '(.*)'")]
        public void ThenTheResultShouldBe(Decimal p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The result  should be '(.*)' '(.*)'")]
        public void ThenTheResultShouldBe(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
