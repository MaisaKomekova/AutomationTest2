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
    class AuthorizationPageObject:BasePage
    {
        private string loginname = "maysaberdyevna";
        private string password = "12345678Bb!";
        private string Mail_To = "maysakomekova@yandex.ru";
        private string Mail_Theme = "Epam";
        private string Mail_Body = "Hello world!";


        private static readonly By _authorizationLbl = By.XPath("//*[@class='passp-page-overlay']");

        private readonly BaseElement _loginInput = new BaseElement(By.XPath("//input[@name='login']"));
        private readonly BaseElement _loginButton = new BaseElement(By.XPath("//button[@id='passp:sign-in']"));

        private readonly BaseElement _passwordInput = new BaseElement(By.Name("passwd"));
        private readonly BaseElement _passwordButton = new BaseElement(By.XPath("//button[@id='passp:sign-in']"));

        private readonly BaseElement _secretworddInput = new BaseElement(By.XPath("//input[@class='Textinput-Control']"));
        private readonly BaseElement _secretworddButton = new BaseElement(By.TagName("button"));


        public AuthorizationPageObject() : base(_authorizationLbl, "Authorization Page") { }


        public void Login()
        {
           _loginInput.SendKeys(loginname);
           _loginButton.Click();
           _passwordInput.SendKeys(password);
           _passwordButton.Click();
        }

    }
}
