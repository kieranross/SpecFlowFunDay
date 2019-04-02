using System;
using TechTalk.SpecFlow;
using TfLData;

namespace SpecificationTest.StepDefinitions
{
    [Binding]
    public class CanConnectToApiSteps
    {
        public ApiCommunicator communicator { get; set; }

        [Given(@"the TFL API at (.*)$")]
        public void GivenTheTFLAPIAt(string apiUrl)
        {
            communicator = new ApiCommunicator(apiUrl);
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the API is queried")]
        public void WhenTheAPIIsQueried()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a list of bike points is returned")]
        public void ThenAListOfBikePointsIsReturned()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
