using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ApplicationCore.Exceptions
{
    public class EmptyBasketOnCheckoutException : Exception
    {
        public EmptyBasketOnCheckoutException() : base($"Basket cannot have 0 items on checkout")
        {

        }

        protected EmptyBasketOnCheckoutException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        public EmptyBasketOnCheckoutException(string message) : base(message)
        {

        }
    }
}
