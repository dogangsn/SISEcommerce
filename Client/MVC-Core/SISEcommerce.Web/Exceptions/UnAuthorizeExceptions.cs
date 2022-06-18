using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SISEcommerce.Web.Exceptions
{
    public class UnAuthorizeExceptions : Exception
    {
        public UnAuthorizeExceptions() : base()
        {
        }

        public UnAuthorizeExceptions(string message) : base(message)
        {
        }

        public UnAuthorizeExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnAuthorizeExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
