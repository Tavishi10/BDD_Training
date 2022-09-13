using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Specflow_Automation.Hooks;

namespace Specflow_Automation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        private AutomationHooks hooks;
        public LoginStepDefinitions(AutomationHooks hooks)
        {
            this.hooks = hooks;
        }

        [Given(@"I have browser with orangehrm page")]
        public void GivenIHaveBrowserWithOrangehrmPage()
        {
            hooks.driver = new ChromeDriver();
            hooks.driver.Manage().Window.Maximize();
            hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            hooks.driver.Url = "https://opensource-demo.orangehrmlive.com/";
        } 

        [When(@"I enter username as '([^']*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            hooks.driver.FindElement(By.Name("username")).SendKeys(username);
           // Console.Write(username);
        }

        [When(@"I enter password as '([^']*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            hooks.driver.FindElement(By.Name("password")).SendKeys(password);
            //Console.WriteLine(password);
            
        }
        

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            Console.WriteLine("thanks");
        }

        [Then(@"I should be navigate to '([^']*)' dashboard screen")]
        public void ThenIShouldBeNavigateToDashboardScreen(string expectedValue)
        {
            Console.WriteLine(expectedValue);
        }
        [Then(@"I should get an error message as '([^']*)'")]
        public void ThenIShouldGetAnErrorMessageAs(string errormessage)
        {
            Console.WriteLine(errormessage);
        }

    }
}
