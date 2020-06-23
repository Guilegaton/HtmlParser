using System;

namespace HtmlParser.Exceptions
{
    public class NotPropertyException : Exception
    {
        private static readonly string _errorMessage = "One member in template invocation chain is not a property of \"{0}\" class. Please check your HTML template";

        public NotPropertyException(Type modelType) : base(string.Format(_errorMessage, modelType.ToString()))
        {
        }

        public NotPropertyException(Type modelType, Exception innerException) : base(string.Format(_errorMessage, modelType.ToString()), innerException)
        {
        }
    }
}
