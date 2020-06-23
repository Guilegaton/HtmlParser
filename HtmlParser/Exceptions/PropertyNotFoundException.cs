using System;

namespace HtmlParser.Exceptions
{
    public class PropertyNotFoundException : Exception
    {
        private static readonly string _errorMessage = "Property \"{0}\" was not found into model of \"{1}\" type. Please, check your HTML template.";

        public PropertyNotFoundException(string propertyName, Type modelType) : base(string.Format(_errorMessage, propertyName, modelType.ToString()))
        {
        }

        public PropertyNotFoundException(string propertyName, Type modelType, Exception innerException) : base(string.Format(_errorMessage, propertyName, modelType.ToString()), innerException)
        {
        }

    }
}
