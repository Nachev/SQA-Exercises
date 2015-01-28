namespace Framework.Core.Extensions
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Extensions to WebDriver
    /// </summary>
    public static class DriverExtensions
    {
        /// <summary>
        /// Gets the text from found element by given <see cref="By"/> mechanism.
        /// </summary>
        /// <param name="driver">Current WebDriver instance.</param>
        /// <param name="by">Provided a mechanism by wich to find elements within a document.</param>
        /// <returns>Text from the found element within a document.</returns>
        public static string GetText(this IWebDriver driver, By by)
        {
            return driver.FindElement(by).Text;
        }

        /// <summary>
        /// Checks if element is present within a document.
        /// </summary>
        /// <param name="driver">Current WebDriver instance.</param>
        /// <param name="by">Provided a mechanism by wich to find elements within a document.</param>
        /// <returns>True if searched element is present.</returns>
        public static bool HasElement(this IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Extension to find element within a document with given timeout in seconds.
        /// </summary>
        /// <param name="driver">Current WebDriver instance.</param>
        /// <param name="by">Provided a mechanism by wich to find elements within a document.</param>
        /// <param name="timeoutInSeconds">Time limit to look for the element./param>
        /// <returns>IWebElement found within the document.</returns>
        /// <exception cref="NoSuchElementException">Thrown when the element was not found within the document.</exception>
        public static IWebElement GetElement(
            this IWebDriver driver,
            By by,
            int timeoutInSeconds = 30)
        {
            IWebElement foundElement = null;
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                foundElement = wait.Until<IWebElement>((d) => { return d.FindElement(by); });
            }
            catch (TimeoutException ex)
            {
                throw new NoSuchElementException("Element not found until timeout", ex);
            }

            return foundElement;
        }

        /// <summary>
        /// Waits for element with given class name to appear within a document.
        /// </summary>
        /// <param name="driver">Current WebDriver instance.</param>
        /// <param name="className">Class name of the element to wait for.</param>
        public static void WaitForElementWithClass(this IWebDriver driver, string className)
        {
            driver.GetElement(By.ClassName(className));
        }

        /// <summary>
        /// Waits for element with given class name to appear within a document, until a given timeout in seconds.
        /// </summary>
        /// <param name="driver">Current WebDriver instance.</param>
        /// <param name="by">Provided a mechanism by wich to find elements within a document.</param>
        /// <param name="className">Class name of the element to wait for.</param>
        /// <param name="timeoutInSeconds">Time limit to look for the element.</param>
        public static void WaitForElementWithClass(
            this IWebDriver driver,
            By by,
            string className,
            int timeoutInSeconds = 30)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until<bool>((d) =>
                {
                    var element = driver.FindElement(by);
                    return element.HasClass(className);
                });
            }
            catch (TimeoutException ex)
            {
                throw new NoSuchElementException("Element with such class is not present", ex);
            }
        }

        /// <summary>
        /// Waits for an element within a document by given <see cref="By"/> mechanism
        /// </summary>
        /// <param name="driver">Current WebDriver instance.</param>
        /// <param name="by">Provided a mechanism by wich to find elements within a document.</param>
        public static void WaitForElementPresent(this IWebDriver driver, By by)
        {
            driver.GetElement(by);
        }
    }
}
