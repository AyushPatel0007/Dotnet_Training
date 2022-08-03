using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{

    public delegate void EventDelegator(int i);
    class Program
    {

        public void Square(int i)
        {
            Console.WriteLine(i * i);
        }
        public void Cube(int i)
        {
            Console.WriteLine(i * i * i);
        }
        public void Four(int i)
        {
            Console.WriteLine(i * i * i * i);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int n = int.Parse(Console.ReadLine());
            EventDelegator ev = new EventDelegator(p.Cube);
            ev.Invoke(n);
            Eventd et = new Eventd();
            et.EventSeparator += User1.Xhandler;
            et.EventSeparator += User2.Yhandler;
            et.Separator(n);
           
        }


    }
    class Eventd
    {
        public event EventDelegator EventSeparator;
        public void Separator(int x)
        {
            if (EventSeparator != null)
            {
                EventSeparator(x);
            }
        }


    }
    class User1 {
        public static void Xhandler(int i)
        {
            Console.WriteLine("X handler");
        }
    
    
    }
    class User2
    {
        public static void Yhandler(int i)
        {
            Console.WriteLine("Y handler");
        }


    }





}
