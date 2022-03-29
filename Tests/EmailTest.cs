using Microsoft.VisualStudio.TestTools.UnitTesting;
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
using AT_Email.PageOjects;
using System.Threading;

namespace AT_Email.Tests
{
    [TestClass]
    public class EmailTest
    {
         IWebDriver driver;

        private string loginname = "maysaberdyevna";
        private string password = "12345678Bb!";
        private string Mail_To = "maysakomekova@yandex.ru";
        private string Mail_Theme = "Epam";
        private string Mail_Body = "Hello world!";

        [TestInitialize]
        public void SetUp()
        {
            string baseUrlYandex = "https://passport.yandex.ru/auth/add?from=mail&origin=hostroot_homer_auth_L_ru&retpath=https%3A%2F%2Fmail.yandex.ru%2F&backpath=https%3A%2F%2Fmail.yandex.ru%3Fnoretpath%3D1";
            this.driver = new ChromeDriver();
            this.driver.Navigate().GoToUrl(baseUrlYandex);
            this.driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void CreateMessageTest()
        {
            var authorizationpage = new AuthorizationPageObject(this.driver);
            authorizationpage.Login(loginname, password);
            var mainmenu = new MainPagePageObject(this.driver);
            string actualLogin = mainmenu.GetUserLogin();
            Assert.AreEqual(loginname, actualLogin);
            mainmenu.CreateNewMsg();
            var createmsg = new CreateMailPageObject(this.driver);
            createmsg.CreateMessage(Mail_To, Mail_Theme, Mail_Body);
            createmsg.SaveMessage();

            var draft = new DraftPageObject(driver);
            mainmenu.Draft();
            Assert.IsNotNull(draft.FindDraft(Mail_Theme));

            mainmenu.LogOut();
        }

        [TestMethod]
        public void DeleteDraftTest()
        {
            var authorizationpage = new AuthorizationPageObject(this.driver);
            authorizationpage.Login(loginname, password);
            var mainmenu = new MainPagePageObject(this.driver);
            string actualLogin = mainmenu.GetUserLogin();
            Assert.AreEqual(loginname, actualLogin);
            var draft = new DraftPageObject(driver);
            mainmenu.Draft();
            Assert.IsNotNull(draft.FindDraft(Mail_Theme));
            draft.DeleteDraft();
            Assert.IsFalse(draft.FindDraft(Mail_Theme));
            mainmenu.LogOut();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
