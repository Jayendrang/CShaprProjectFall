using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentCompanyProject.com.app.business
{
    public class LoginException : Exception
    {

        public LoginException(){ }

        public LoginException(string exceptionMessage) : base(exceptionMessage) {}

        public LoginException(string exceptionMessage, Exception innerException) : base(exceptionMessage, innerException) { }



    }

    public class OrderException : Exception
    {
        public OrderException() { }

        public OrderException(string exceptionMessage) : base(exceptionMessage) { }

        public OrderException(string exceptionMessage, Exception innerException) : base(exceptionMessage, innerException) { }
            
    }

    public class OrderReturnException : Exception
    {
        public OrderReturnException() { }

        public OrderReturnException(string exceptionMessage) : base(exceptionMessage) { }

        public OrderReturnException(string exceptionMessage, Exception innerException) : base(exceptionMessage, innerException) { }
    }
}
