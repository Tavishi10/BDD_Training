using System;
using TechTalk.SpecFlow;
using RestSharp;

namespace Specflow_Automation.StepDefinitions
{
    [Binding]
    public class StoreStepDefinition
    {
        RestClient restClient;
        RestRequest request;
        RestResponse response;

        [Given(@"I have base url '([^']*)' and resource '([^']*)'")]
        public void GivenIHaveBaseUrlAndResource(string baseUrl, string resource)
        {
            restClient = new RestClient(baseUrl+resource);
        }

        [When(@"I do the Get request")]
        public void WhenIDoTheGetRequest()
        {
            request = new RestRequest();
            response = restClient.Execute(request);
        }

        [Then(@"I should get the response as (.*)")]
        public void ThenIShouldGetTheResponseAs(int expectedResponseCode)
        {
            //Assert.True(response.StatusCode.Equals(System.Net.HttpStatusCode.OK));
            int actualStatusCode = (int)response.StatusCode;
            Assert.Equal(expectedResponseCode, actualStatusCode);
        }

        [Then(@"I should get the message as '([^']*)'")]
        public void ThenIShouldGetTheMessageAs(string expectedMessage)
        {
            string actualResponse = response.Content;
            Assert.Contains(expectedMessage, actualResponse);
        }

        [Then(@"I should get the pet details in json format")]
        public void ThenIShouldGetThePetDetailsInJsonFormat()
        {
        }
       
    }
}

