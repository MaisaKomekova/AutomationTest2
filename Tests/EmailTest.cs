using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using AT_Email.PageOjects;
using System.Threading;

namespace AT_Email.Tests
{
    [TestClass]
    public class EmailTest : BaseTest
    {
        private string BaseUrl = "https://passport.yandex.ru/auth?from=mail&origin=hostroot_homer_auth_ru&retpath=https%3A%2F%2Fmail.yandex.ru%2F&backpath=https%3A%2F%2Fmail.yandex.ru%3Fnoretpath%3D1";
        private MainPagePageObject mainPage;
        private AuthorizationPageObject authorizationPage;
        BaseTest baseTest;





        [Test]
        public void NewMailTest()
        {
            mainPage = new MainPagePageObject();
            authorizationPage = new AuthorizationPageObject();
            authorizationPage.Login();
            //Assert.AreEqual(loginname, mainPage.GetUserLogin());
        }



        //[TestInitialize]
        //public void SetUp()
        //{
        //    string baseUrlYandex = "https://passport.yandex.ru/auth/add?from=mail&origin=hostroot_homer_auth_L_ru&retpath=https%3A%2F%2Fmail.yandex.ru%2F&backpath=https%3A%2F%2Fmail.yandex.ru%3Fnoretpath%3D1";
        //    this.driver = new ChromeDriver();
        //    this.driver.Navigate().GoToUrl(baseUrlYandex);
        //    this.driver.Manage().Window.Maximize();
        //}

        //[TestMethod]
        //public void CreateMessageTest()
        //{
        //    var authorizationpage = new AuthorizationPageObject(this.driver);
        //    authorizationpage.Login(loginname, password);
        //    var mainmenu = new MainPagePageObject(this.driver);
        //    string actualLogin = mainmenu.GetUserLogin();
        //    Assert.AreEqual(loginname, actualLogin);
        //    mainmenu.CreateNewMsg();
        //    var createmsg = new NewMailPageObject(this.driver);
        //    createmsg.CreateMessage(Mail_To, Mail_Theme, Mail_Body);
        //    createmsg.SaveMessage();

        //    var draft = new DraftPageObject(driver);
        //    mainmenu.Draft();
        //    Assert.IsNotNull(draft.FindDraft(Mail_Theme));

        //    mainmenu.LogOut();
        //}

        //[TestMethod]
        //public void DeleteDraftTest()
        //{
        //    var authorizationpage = new AuthorizationPageObject(this.driver);
        //    authorizationpage.Login(loginname, password);
        //    var mainmenu = new MainPagePageObject(this.driver);
        //    string actualLogin = mainmenu.GetUserLogin();
        //    Assert.AreEqual(loginname, actualLogin);
        //    var draft = new DraftPageObject(driver);
        //    mainmenu.Draft();
        //    Assert.IsNotNull(draft.FindDraft(Mail_Theme));
        //    draft.DeleteDraft();
        //    Assert.IsFalse(draft.FindDraft(Mail_Theme));
        //    mainmenu.LogOut();
        //}

        //[TestCleanup]
        //public void Cleanup()
        //{
        //    driver.Close();
        //    driver.Quit();
        //}

    }
}
