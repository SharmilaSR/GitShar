using HRM.Pages;
using OpenQA.Selenium;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.StepDefs
{
    public class PIMSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;
        PIMPage pimPage;
        public PIMSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = (IWebDriver)_scenarioContext["driver"];
            pimPage = new PIMPage(_driver);

        }

        [When("I navigate to the {string} section")]
        public void WhenINavigateToTheSection(string pageName)
        {
            pimPage.NavigateToPagePIM(pageName);
        }

    }
}
