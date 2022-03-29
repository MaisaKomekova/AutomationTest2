using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using System.Threading;

namespace AT_Email.PageOjects
{
    class MainPagePageObject
    {
        IWebDriver webDriver;

        private readonly By _userLogin2 = By.XPath("//a[@class='user-account user-account_left-name user-account_has-ticker_yes user-account_has-accent-letter_yes count-me legouser__current-account legouser__current-account i-bem']/child::span[1]");
        private readonly By _createmessageButton = By.XPath("//a[@class='mail-ComposeButton js-main-action-compose']");

        private readonly By _userAccounntButton = By.XPath("//a[@class='user-account user-account_left-name user-account_has-ticker_yes user-account_has-accent-letter_yes count-me legouser__current-account legouser__current-account i-bem']");
        private readonly By _logoutButton = By.XPath("//a[@class='menu__item menu__item_type_link count-me legouser__menu-item legouser__menu-item_action_exit legouser__menu-item legouser__menu-item_action_exit']");

        private readonly By _draftButton = By.XPath("//a[@href='#draft']");

        public MainPagePageObject(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public string GetUserLogin()
        {
            WaitShowElement(_userLogin2);
            string userLogin = webDriver.FindElement(_userLogin2).Text;
            return userLogin;
        }

        public CreateMailPageObject CreateNewMsg()
        {
            WaitShowElement(_createmessageButton);
            webDriver.FindElement(_createmessageButton).Click();
            return new CreateMailPageObject(webDriver);
        }

        public AuthorizationPageObject LogOut()
        {
            WaitShowElement(_userAccounntButton);
            webDriver.FindElement(_userAccounntButton).Click();
            WaitShowElement(_logoutButton);
            webDriver.FindElement(_logoutButton).Click();
            return new AuthorizationPageObject(webDriver);
        }


        public DraftPageObject Draft()
        {
            WaitShowElement(_draftButton);
            webDriver.FindElement(_draftButton).Click();
            return new DraftPageObject(webDriver);
        }

        public void WaitShowElement(By search)
        {
            WebDriverWait iWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            iWait.Until(d => d.FindElement(search));
        }

    }
}
