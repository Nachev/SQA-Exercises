namespace Framework.Core.Exceptions
{
    using System;

    public class ElementNotFoundException : ApplicationException
    {
        public ElementNotFoundException(string locator, string pageUrl)
            : base(string.Format("The element with locator \"{0}\" on page: \"{1}\" is not found after timeout.", locator, pageUrl))
        {
        }
    }
}
