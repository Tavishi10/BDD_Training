using OpenQA.Selenium;
using System;
namespace Specflow_Automation.Hooks
{
	[Binding]
	public class AutomationHooks
	{
		public static IWebDriver driver;

        [AfterScenario]
        public void EndScenario()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}

