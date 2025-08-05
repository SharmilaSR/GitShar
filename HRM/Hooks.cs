using OpenQA.Selenium;
using Reqnroll;

namespace HRM
{
    [Binding]
    public sealed class Hooks
    {
        private ScenarioContext _scenarioContext;
        private  IWebDriver _driver;
        DriverFactory driverFactory;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driverFactory = new DriverFactory();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = driverFactory.CreateDriver();
            _scenarioContext["driver"] = _driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driverFactory.CloseDriver();
        }
    }
}
