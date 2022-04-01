using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AT_Email.WebDriver;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AT_Email.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected static Browser browser = Browser.Instance;

        protected IWebDriver driver;

        [TestInitialize]
        public virtual void InitTest()
        {
            //browser = Browser.Instance;
            //Browser.WindowMaximize();
            //Browser.NavigateTo(Configuration.StartUrl);

            string baseUrlYandex = "https://passport.yandex.ru/auth/add?from=mail&origin=hostroot_homer_auth_L_ru&retpath=https%3A%2F%2Fmail.yandex.ru%2F&backpath=https%3A%2F%2Fmail.yandex.ru%3Fnoretpath%3D1";
            this.driver = new ChromeDriver();
            this.driver.Navigate().GoToUrl(baseUrlYandex);
            this.driver.Manage().Window.Maximize();
        }

        //[TestCleanup]
        //public virtual void CleanTest()
        //{
        //    Browser.Quit();
        //}

    }
}
