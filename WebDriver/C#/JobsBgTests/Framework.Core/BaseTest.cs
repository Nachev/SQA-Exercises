namespace Framework.Core
{
    using System;
    using Framework.Core.Exceptions;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }

        protected string BaseUri { get; private set; }

        protected int Timeout { get; private set; }

        protected WebDriverWait Wait { get; private set; }

        public void BaseTestInitialize(IWebDriver initialDriver, string baseUri, int timeout)
        {
            this.Driver = initialDriver;
            this.BaseUri = baseUri;
            this.Timeout = timeout;
            this.Wait = new WebDriverWait(initialDriver, TimeSpan.FromSeconds(timeout));
        }

        //public IWebElement GetElement(By by)
        //{
        //    IWebElement foundElement;
        //    try
        //    {
        //        foundElement = this.Wait.Until<IWebElement>((d) => { return d.FindElement(by); });
        //    }
        //    catch (TimeoutException)
        //    {
        //        throw new ElementNotFoundException(by.ToString(), this.BaseUri);
        //    }

        //    return foundElement;
        //}

        //public void WaitForElementPresent(By by)
        //{
        //    this.GetElement(by);
        //}

        //public bool IsElementPresent(By by)
        //{
        //    try
        //    {
        //        this.Driver.FindElement(by);
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //}

        //public void WaitForElementNotPresent(By by)
        //{
        //    try
        //    {
        //        var currentElement = this.Driver.FindElement(by);
        //        bool notVisible = this.Wait.Until<bool>((d) => { return !currentElement.Displayed; });
        //        if (notVisible)
        //        {
        //            return;
        //        }

        //        throw new ElementStillPresentException(by.ToString(), this.BaseUri);
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return;
        //    }
        //    catch (TimeoutException)
        //    {
        //        throw new ElementStillPresentException(by.ToString(), this.BaseUri);
        //    }
        //}
    }
}
