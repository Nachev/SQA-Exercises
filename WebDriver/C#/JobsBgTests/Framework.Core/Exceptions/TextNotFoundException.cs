namespace Framework.Core.Exceptions
{
    using System;

    public class TextNotFoundException : ApplicationException
    {
        public TextNotFoundException(string url, string value) 
            : base(string.Format("The text \"{0}\", was not found at location \"{1}\"", value, url))
        {
        }
    }
}
