using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookDetails
{
    public class MyException:Exception
    {
        public string NoData()
        {
            return "Currently no data in display data found";
        }
    }
}