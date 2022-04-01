using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace AT_Email.PageOjects
{
    public class BasePage
    {
        protected By _titleLocator;
        protected string _title;
        public static string _titleForm;

        public BasePage(By titleLocator, string title)
        {
            _titleLocator = titleLocator;
            _title = title;
            AssertIsOpen();
        }

        public void AssertIsOpen()
        {
            var label = new BaseElement(_titleLocator, _title);
            label.WaitForIsVisible();
        }
    }
}
