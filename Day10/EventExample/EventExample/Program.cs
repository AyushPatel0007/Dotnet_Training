using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EventExample
{
    public delegate void DelEventHandler();


    class Program:Form
    {
        public event DelEventHandler add;

        public Program()
        {
            Button b1 = new Button();
            b1.Parent = this;
            b1.Text = "hit  me";
            b1.Location = new Point(100, 100);
            b1.Click += new EventHandler(onClick);
            add += new DelEventHandler(initated);
            add();
        }
        public void onClick(object sender,EventArgs e)
        {
            MessageBox.Show("Clicked");
        }
        public void initated()
        {
            Console.WriteLine("Initated");
        }
        static void Main(string[] args)
        {
            Application.Run(new Program());
           
                 
        }
    }
}
