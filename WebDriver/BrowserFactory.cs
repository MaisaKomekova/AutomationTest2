using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace AT_Email.WebDriver
{
    public class BrowserFactory
    {
        public enum BrowserType
        {
            Chrome,
            Firefox
        }

        public static IWebDriver GetDriver(BrowserType type, int timeOutSee)
        {
            IWebDriver driver = null;

            switch(type)
            {
                case BrowserType.Chrome:
                    {
                        var service = ChromeDriverService.CreateDefaultService();
                        var option = new ChromeOptions();
                        option.AddArgument("disable-infobars");
                        driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeOutSee));
                        break;
                    }
                case BrowserType.Firefox:
                    {
                        var service = FirefoxDriverService.CreateDefaultService();
                        var option = new FirefoxOptions();
                        driver = new FirefoxDriver(service, option, TimeSpan.FromSeconds(timeOutSee));
                        break;
                    }
                //case BrowserType.remoteChrome:
                //    {
                //        var capability = DesiredCapabilities.Chrome();
                //        CapabilityType.BrowserName;
                //        var option = new ChromeOptions();
                //        option.AddArgument("disable-infobars");
                //        driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeOutSee));
                //        break;
                //    }
                //case BrowserType.remoteFirefox:
                //    {
                //        var service = FirefoxDriverService.CreateDefaultService();
                //        var option = new FirefoxOptions();
                //        driver = new FirefoxDriver(service, option, TimeSpan.FromSeconds(timeOutSee));
                //        break;
                //    }
            }

            return driver;
        }

    }
}
