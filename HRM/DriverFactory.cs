using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HRM
{
    public class DriverFactory
    {
        IWebDriver driver;

        public IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
            return driver;
        }

        public void CloseDriver()
        {
            driver.Quit();
        }
    }
}
