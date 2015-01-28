namespace Framework.Core.Extensions
{
    using System;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Internal;

    /// <summary>
    /// Extension methods to <see cref="WebElements"/> class.
    /// </summary>
    public static class ElementExtensions
    {
        /// <summary>
        /// Overload to SendKeys method with option to clear the content of WebElement first.
        /// </summary>
        /// <param name="element">Current WebElement instance.</param>
        /// <param name="value">Value to be entered in the input field.</param>
        /// <param name="clearFirst">If true clears the content of the field first.</param>
        public static void SendKeys(this IWebElement element, string value, bool clearFirst)
        {
            if (clearFirst)
            {
                element.Clear();
            }

            element.SendKeys(value);
        }

        /// <summary>
        /// Sets a given value to an attribute of the current WebElement.
        /// </summary>
        /// <param name="element">Current WebElement instance.</param>
        /// <param name="attributeName">Name of the attribute to which to set value.</param>
        /// <param name="value">Value of the attribute to be set.</param>
        public static void SetAttribute(this IWebElement element, string attributeName, string value)
        {
            IWrapsDriver wrappedElement = element as IWrapsDriver;
            if (wrappedElement == null)
            {
                throw new ArgumentException("Element must wrap a web driver", "element");
            }

            IWebDriver driver = wrappedElement.WrappedDriver;
            IJavaScriptExecutor javascript = driver as IJavaScriptExecutor;
            if (javascript == null)
            {
                throw new ArgumentException("Element must wrap a web driver that supports javascript execution", "element");
            }

            javascript.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2])", element, attributeName, value);
        }

        /// <summary>
        /// Checks if this WebElement has class with given name. 
        /// </summary>
        /// <param name="element">Current WebElement instance.</param>
        /// <param name="className">Class name to look for.</param>
        /// <returns>True if this WebElement has class with given name.</returns>
        public static bool HasClass(this IWebElement element, string className)
        {
            return element.GetAttribute("class").Split(' ').Contains(className);
        }
    }
}
