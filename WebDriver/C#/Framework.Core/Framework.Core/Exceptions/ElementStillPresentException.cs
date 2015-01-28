namespace Framework.Core.Exceptions
{
    using System;

    public class ElementStillPresentException : ApplicationException
    {
        public ElementStillPresentException(string locator, string pageUrl)
            : base(string.Format("Element found with locator \"{0}\" is still present at page \"{1}\" after timeout.", locator, pageUrl))
        {
        }
    }
}
