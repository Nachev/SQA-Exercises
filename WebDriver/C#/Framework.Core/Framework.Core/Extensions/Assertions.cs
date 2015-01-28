namespace Framework.Core.Extensions
{
    using Framework.Core.Exceptions;
    using OpenQA.Selenium;
    using System;

    /// <summary>
    /// Extensions for assertions.
    /// </summary>
    public static class Assertions
    {
        /// <summary>
        /// Asserts if text with given value is present at the current page, opened by the current WebDriver.
        /// </summary>
        /// <param name="driver">Current WebDriver used.</param>
        /// <param name="value">Text to search for at the current page.</param>
        /// <exception cref="TextNotFoundException">Thrown when text with given value is not present at the page.</exception>
        public static void AssertTextPresent(this IWebDriver driver, string value)
        {
            if (!driver.PageSource.Contains(value))
            {
                throw new TextNotFoundException(driver.Url, value);
            }
        }

        /// <summary>
        /// Asserts if text with given value is present in the current element.
        /// </summary>
        /// <param name="element">Current WebElement.</param>
        /// <param name="driver">Current WebDriver.</param>
        /// <param name="value">Text value to search for in the element.</param>
        /// <exception cref="TextNotFoundException">Thrown when text with given value is not present in the element.</exception>
        public static void AssertTextPresentInElement(this IWebElement element, IWebDriver driver, string value)
        {
            if (!element.Text.Contains(value))
            {
                throw new TextNotFoundInElementException(driver.Url, element.TagName, value);
            }
        }
    }
}
