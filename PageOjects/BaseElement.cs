using System;
using OpenQA.Selenium;
using AT_Email.WebDriver;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Collections.ObjectModel;


namespace AT_Email.PageOjects
{
    public class BaseElement: IWebElement
    {
        private IWebDriver _driver = Browser.GetDriver();
        protected string _name;
        protected By _locator;
        protected IWebElement _webElement;



        public BaseElement(By locator, string name)
        {
            _locator = locator;
            _name = name == "" ? GetText():name ;
        }

        public BaseElement(By locator)
        {
            _locator = locator;
        }

        public string GetText()
        {
            WaitForIsVisible();
            return _webElement.Text;
        }

        public IWebElement GetElement()
        {
            try
            {
                _webElement = Browser.GetDriver().FindElement(_locator);
            }
            catch(Exception)
            {
                throw;
            }
            return _webElement;
        }

        public void WaitForIsVisible()
        {
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 1, 30));
            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _driver.FindElement(_locator);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
            );
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            WaitForIsVisible();
            Browser.GetDriver().FindElement(_locator).SendKeys(text);
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            WaitForIsVisible();
            Browser.GetDriver().FindElement(_locator).Click();
        }

        public void JsClick()
        {
            WaitForIsVisible();
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Browser.GetDriver();
            executor.ExecuteScript("arguments[0].click();", GetElement());
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetDomAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetDomProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public ISearchContext GetShadowRoot()
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By @by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }
        public string TagName { get; }
        public string Text { get; }
        public bool Enabled { get; }
        public bool Selected { get; }
        public Point Location { get; }
        public Size Size { get; }
        public bool Displayed { get; }

    }
}
