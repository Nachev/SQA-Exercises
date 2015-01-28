namespace Framework.Core.Extensions
{
    using System;

    public class TextNotFoundInElementException : ApplicationException
    {
        public TextNotFoundInElementException(string driverUrl, string tagName, string value)
            : base(string.Format("The text \"{0}\" was not found in the element \"{1}\" at url \"{2}\"", value, tagName, driverUrl)) 
        {
        }
    }
}
