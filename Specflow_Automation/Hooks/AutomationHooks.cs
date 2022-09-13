using OpenQA.Selenium;
using System;
[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace Specflow_Automation.Hooks
{
	[Binding]
	public class AutomationHooks
	{
		public IWebDriver driver;

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

