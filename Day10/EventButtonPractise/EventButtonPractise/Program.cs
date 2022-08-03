using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EventButtonPractise
{

    public delegate void Createevent();
    class Program:Form
    {
        public event Createevent Eventinit;

        public void message()
        {
            Console.WriteLine("Hiited 1");
        }
        public void  onClick(object sender,EventArgs e)
        {
           MessageBox.Show("Hiited 2");
        }
        public Program()
        {
            Button b1 = new Button();
            b1.Parent = this;
            b1.Location = new Point(100, 100);
            b1.Text = "Hit me";
            Eventinit += new Createevent(message);
            b1.Click += new EventHandler(onClick);
            Eventinit();


        }
        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
