using OpenQA.Selenium;
using Specflow_Automation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Emergency_ContactStepDefinitions

    {
        private AutomationHooks hooks;
        public Emergency_ContactStepDefinitions(AutomationHooks hooks)
        {
            this.hooks = hooks;
        }

        string fName;

        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            hooks.driver.FindElement(By.XPath("//span[text()='My Info']")).Click();

        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            hooks.driver.FindElement(By.XPath("//a[text()='Emergency Contacts']")).Click();
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            hooks.driver.FindElement(By.XPath("//h6[contains(@class,'orange')]/following::button")).Click();
        }

        [When(@"I fill emergency contact")]
        public void WhenIFillEmergencyContact(Table table)
        {
            fName = table.Rows[0]["name"];
            string relationship = table.Rows[0]["relationship"];
            string home_telephone = table.Rows[0]["home_telephone"];
            string mobile = table.Rows[0]["mobile"];
            string work_telephone = table.Rows[0]["work_telephone"];

            hooks.driver.FindElement(By.XPath("//label[contains(text(),'Name')]/following::input")).SendKeys(fName);
            hooks.driver.FindElement(By.XPath("//label[contains(text(),'Relationship')]/following::input")).SendKeys(relationship);
            hooks.driver.FindElement(By.XPath("//label[contains(text(),'Home Tele')]/following::input")).SendKeys(home_telephone);
            hooks.driver.FindElement(By.XPath("//label[contains(text(),'Mobile')]/following::input")).SendKeys(mobile);
            hooks.driver.FindElement(By.XPath("//label[contains(text(),'Work')]/following::input")).SendKeys(work_telephone);
        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            hooks.driver.FindElement(By.XPath("//button[@type= 'submit']")).Click();
        }

        [Then(@"I should navigate to emergency contact details")]
        public void ThenIShouldNavigateToEmergencyContactDetails()
        {
            string actualData = hooks.driver.FindElement(By.XPath("//div[@class='oxd-table']")).Text;
            Assert.Contains(fName, actualData);
        }
    }
}
