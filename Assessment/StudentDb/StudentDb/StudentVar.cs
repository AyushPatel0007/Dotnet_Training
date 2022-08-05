using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb
{
    internal class StudentVar
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Address { get; set; }
        public StudentVar(int id ,string Name,int Mark,string Address)
        {
            this.id = id;
            this.Name = Name;
            this.Marks = Mark;
            this.Address = Address;
        }
        
    }
}
