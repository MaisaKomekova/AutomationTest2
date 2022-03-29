using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AT_Email.PageOjects
{
    class AuthorizationPageObject
    {
        IWebDriver _driver;


        private readonly By _loginInput = By.XPath("//input[@name='login']");
        private readonly By _loginButton = By.XPath("//button[@id='passp:sign-in']");

        private readonly By _passwordInput = By.Name("passwd");
        private readonly By _passwordButton = By.XPath("//button[@id='passp:sign-in']");


        public AuthorizationPageObject(IWebDriver driver)
        {
            this._driver = driver;
        }

        public MainPagePageObject Login(string  login, string password)
        {
            WaitShowElement(_loginInput);
            _driver.FindElement(_loginInput).SendKeys(login);
            _driver.FindElement(_loginButton).Click();
            WaitShowElement(_passwordInput);
            _driver.FindElement(_passwordInput).SendKeys(password);
            _driver.FindElement(_passwordButton).Click();
            return new  MainPagePageObject(_driver);
        }

        public void WaitShowElement(By search)
        {
            WebDriverWait iWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            iWait.Until(d => d.FindElement(search));
        }

    }
}
