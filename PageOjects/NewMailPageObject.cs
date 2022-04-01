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
    class NewMailPageObject
    {
        IWebDriver _driver;

        private readonly By _messageToInput=By.XPath("/html/body/div[2]/div[2]/div[10]/div/div/div[1]/div/div[2]/div/div[1]/div[1]/div[1]/div/div[1]/div[1]/div[1]/div/div/div/div/div");
        private readonly By _meassgeThemeInput = By.XPath("//input[@name='subject']");
        private readonly By _meassgeBodyInput = By.XPath("//*[@id='cke_1_contents']/div/div");
        private readonly By _closeButton = By.XPath("//*[@id='js-apps-container']/div[2]/div[10]/div/div/div[1]/div/div[1]/div/div[2]/div/div[3]/button");

        public NewMailPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void  CreateMessage(string to_str, string theme, string body)
        {
            WaitShowElement(_messageToInput);
            _driver.FindElement(_messageToInput).SendKeys(to_str);
            _driver.FindElement(_meassgeThemeInput).SendKeys(theme);
            _driver.FindElement(_meassgeBodyInput).SendKeys(body);
        }

        //public MainPagePageObject SaveMessage()
        //{ 
        //    // так как почта автоматически сохраняет письмо в черновиках + нет кнопки "Сохранить" , нажимаем на кнопку закрыть
        //    WaitShowElement(_closeButton);
        //    _driver.FindElement(_closeButton).Click();
        //    return new MainPagePageObject(this._driver);
        //}

        public void WaitShowElement(By search)
        {
            WebDriverWait iWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            iWait.Until(d => d.FindElement(search));
        }

    }
}
