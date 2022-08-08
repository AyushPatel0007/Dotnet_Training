using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_mgmt
{
    class Patient
    {
        public string Name;
        public int Age;
        public string Address;
        public string Disease;
        public string Doccharge;
        public int Roomno;


        public Patient(string name,int age,string add, string dis, string doc,int room)
        {
            this.Name = name;
            this.Age = age;
            this.Address = add;
            this.Doccharge = doc;
            this.Roomno = room;
            this.Disease = dis;
        }
        public string _Disease()
        {
            return Disease;
        }
        public string _Name()
        {
            return Name;
        }
        public int _Age()
        {
            return Age;
        }

        public string _Addres()
        {
            return Address;
        }

        public string _Doc()
        {
            return Doccharge;
        }
        public int _Room()
        {
            return Roomno;
        }
    }
}
