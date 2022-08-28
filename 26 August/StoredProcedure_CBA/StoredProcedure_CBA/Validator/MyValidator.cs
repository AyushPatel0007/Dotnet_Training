using StoredProcedure_CBA.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcedure_CBA.Validator
{
    public class MyValidator
    {
        public static void Validate(int i)
        {
            if (i > 2)
            {
                throw new MyException($"{nameof(i)} is greater than 2");
            }
        }
    }
}