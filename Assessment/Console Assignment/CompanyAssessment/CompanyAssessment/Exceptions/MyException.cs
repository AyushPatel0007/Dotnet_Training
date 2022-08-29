using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyAssessment.Exceptions
{
    public class MyException1 : Exception
    {
        public string msg1 { get; set; }
        public MyException1()
        {
            msg1 = "This is error page";
        }
        public MyException1(string msg) : base(msg)
        {
            msg1 = msg;
        }
    }
    public class Foreignkey : Exception
    {
        public string msg1 { get; set; }
        public Foreignkey()
        {
            msg1 = "This is foreign key error";
        }
        public Foreignkey(string msg) : base(msg)
        {
            msg1 = msg;
        }
    }
    public class NullDataFound : Exception
    {
        public string msg1 { get; set; }
        public NullDataFound()
        {
            msg1 = " NullData found error";
        }
        public NullDataFound(string msg) : base(msg)
        {
            msg1 = msg;
        }
    }
    public class WrongInput : Exception
    {
        public string msg1 { get; set; }
        public WrongInput()
        {
            msg1 = "This is Wrong Input error";
        }
        public WrongInput(string msg) : base(msg)
        {
            msg1 = msg;
        }
    }
}