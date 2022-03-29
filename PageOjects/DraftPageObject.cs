using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AT_Email.PageOjects
{
    class DraftPageObject
    {

        IWebDriver _webdriver;

        private readonly By _searchInput = By.XPath("//input[@class='textinput__control']");
        private readonly By _searchButton = By.XPath("//button[@class='control button2 button2_view_default button2_tone_mail-suggest-themed button2_size_n button2_theme_normal button2_pin_clear-round button2_type_submit search-input__form-button']");

        private readonly By _draftResults = By.XPath("//span[@class='mail-MessagesSearchInfo-Title_misc nb-with-xs-left-gap']");

        private readonly By _chekboxButton = By.XPath("//*[@id='js-apps-container']/div[2]/div[7]/div/div[3]/div[3]/div[3]/div[1]/div[2]/div[2]/div/div[2]/div/div/div[1]/label/span");
        //private readonly By _chekboxButton = By.XPath("//div[1]/label/span[@class='checkbox_view']");
        private readonly By _deleteButton = By.XPath("//*[@id='js-apps-container']/div[2]/div[7]/div/div[3]/div[3]/div[3]/div[1]/div[2]/div[2]/div/div[2]/div/div/div[5]");


        public DraftPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }


        public bool FindDraft(string thema)
        {

            WaitShowElement(_searchInput);
            _webdriver.FindElement(_searchInput).Clear();
            _webdriver.FindElement(_searchInput).SendKeys(thema);
            _webdriver.FindElement(_searchButton).Click();

            if(isDraftExact(_draftResults)==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteDraft()
        {
            WaitShowElement(_chekboxButton);
            _webdriver.FindElement(_chekboxButton).Click();
            WaitShowElement(_deleteButton);
            _webdriver.FindElement(_deleteButton).Click();
            _webdriver.FindElement(_searchInput).Clear();
        }


        public bool isDraftExact(By thema)
        {
            try
            {
                _webdriver.FindElement(thema);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        public void WaitShowElement(By search)
        {
            WebDriverWait iWait = new WebDriverWait(_webdriver, TimeSpan.FromSeconds(20));
            iWait.Until(d => d.FindElement(search));
        }


    }
}
