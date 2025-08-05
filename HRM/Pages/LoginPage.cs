using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private readonly By inputUsername = By.Name("username");
        private readonly By inputPassword = By.Name("password");
        private readonly By btnLogin = By.XPath("//button[contains(@class,'orangehrm-login-button')]");

        private readonly By userDropdown = By.ClassName("oxd-userdropdown-name");
        public LoginPage(IWebDriver driver) 
        {
            _driver = driver;
        }

        internal bool EnterUserNameAndPassword(string uname, string pword)
        {
            _driver.FindElement(inputUsername).SendKeys(uname);
            _driver.FindElement(inputPassword).SendKeys(pword);
            _driver.FindElement(btnLogin).Click();
            return _driver.FindElement(userDropdown).Displayed;
        }

        internal void UserIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }
    }
}
