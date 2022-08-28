using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StoredProcedure_CBA.Exceptions
{
    
    public class MyException:Exception
    {
        public MyException()
        {

        }
        public MyException(string message):base(message)
        {

        }
        public MyException(string message,Exception innerException) : base(message, innerException)
        {

        }
        public MyException(SerializationInfo message, StreamingContext innerException) : base(message, innerException)
        {

        }

    }
}