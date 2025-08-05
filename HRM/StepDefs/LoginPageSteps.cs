using HRM.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace HRM.StepDefs
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;
        LoginPage loginPage;
        public LoginPageSteps(ScenarioContext scenarioContext) 
        {
            _scenarioContext = scenarioContext;
            _driver = (IWebDriver)_scenarioContext["driver"];
            loginPage = new LoginPage(_driver);
        
        }

        [Given("I am on the OrangeHRM login page")]
        public void GivenIAmOnTheOrangeHRMLoginPage()
        {
            loginPage.UserIsOnTheLoginPage();
        }

        [When("I log in with username {string} and password {string}")]
        public void WhenILogInWithUsernameAndPassword(string uname, string pword)
        {
            Assert.That(loginPage.EnterUserNameAndPassword(uname, pword), Is.True);           
        }

    }
}
