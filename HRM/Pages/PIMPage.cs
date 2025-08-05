using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Pages
{
    public class PIMPage
    {
        private IWebDriver _driver;
        private readonly By linksToNaviagte = By.XPath("//ul[@class='oxd-main-menu']//li//a");

        public PIMPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void NavigateToPagePIM(string pageName)
        {
            IList<IWebElement> links = _driver.FindElements(linksToNaviagte);
            foreach (IWebElement link in links)
            {
                if (link.GetAttribute("href").ToLower().Contains(pageName.ToLower()))
                {
                    link.Click();
                    break;
                }
            }
        }
    }
}
