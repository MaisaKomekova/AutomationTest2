using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System.Threading;

namespace AT_Email.PageOjects
{
    class MainPagePageObject : BasePage
    {
        private static readonly By MainLbl = By.Id("js-apps-container");

        public MainPagePageObject() : base(MainLbl, "Main Page") { }

        //IWebDriver webDriver;

        private readonly BaseElement _userLogin2 = new BaseElement(By.XPath("//a[@class='user-account user-account_left-name user-account_has-ticker_yes user-account_has-accent-letter_yes count-me legouser__current-account legouser__current-account i-bem']/child::span[1]"));
            
        private readonly BaseElement _createmessageButton = new BaseElement(By.XPath("//a[@class='mail-ComposeButton js-main-action-compose']"));

        private readonly BaseElement _userAccounntButton = new BaseElement(By.XPath("//a[@class='user-account user-account_left-name user-account_has-ticker_yes user-account_has-accent-letter_yes count-me legouser__current-account legouser__current-account i-bem']"));
        private readonly BaseElement _logoutButton = new BaseElement(By.XPath("//a[@class='menu__item menu__item_type_link count-me legouser__menu-item legouser__menu-item_action_exit legouser__menu-item legouser__menu-item_action_exit']"));

        private readonly BaseElement _draftButton = new BaseElement(By.XPath("//a[@href='#draft']"));



        public string GetUserLogin()
        {
            string userLogin = _userLogin2.Text;
            return userLogin;
        }

        //public NewMailPageObject CreateNewMsg()
        //{
        //   _createmessageButton.Click();
        //    return new CreateMailPageObject();
        //}

        //public AuthorizationPageObject LogOut()
        //{
        //    _userAccounntButton.Click();
        //    _logoutButton.Click();
        //    return new AuthorizationPageObject(webDriver);
        //}


        //public DraftPageObject Draft()
        //{
        //    _draftButton.Click();
        //    return new DraftPageObject(webDriver);
        //}


    }
}
