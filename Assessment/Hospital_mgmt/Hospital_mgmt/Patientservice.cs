using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_mgmt
{
    class Patientservice
    {
        public Patientservice()
        {

        }
        public bool Add(List<Patient> pt)
        {
            
            Console.Write("Enter Name : ");
            string n = Console.ReadLine();
            Console.Write("Enter Age: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Address : ");
            string add = Console.ReadLine();
            Console.Write("Enter Disease : ");
            string d = Console.ReadLine();
            Console.Write("Enter Doc charge: ");
            string doc =Console.ReadLine();
            Console.Write("Enter Roomno: ");
            int room = int.Parse(Console.ReadLine());
            pt.Add(new Patient(n, a,add, d, doc, room));
            return true;

        }

        public bool Display(List<Patient> pt)
        {
            try
            {
                if (pt.Count() == 0)
                 throw new Myexception();
            }
            catch(Myexception e)
            {
                Console.WriteLine("-----------------------------------------");
                e.Notfound();
                Console.WriteLine("-----------------------------------------");
                return true;

            }
            Console.WriteLine("---------Result-------------");

            foreach (Patient ob in pt)
            {
                Console.WriteLine(" Name : " + ob._Name() +"|Age: "+ob._Age()+ "| Address :" + ob._Addres() + "| Disease: " + ob._Disease()+"| Roomno : "+ob._Room()+" | Doctor Charges: "+ob._Doc()) ;
            }
            Console.WriteLine("----------------------");

            return true;
        }
        
        public bool Delete(List<Patient> pt)
        {
            try
            {
                if (pt.Count() == 0)
                    throw new Myexception();
            }
            catch (Myexception e)
            {
                Console.WriteLine("-----------------------------------------");
                e.Notfound();
                Console.WriteLine("-----------------------------------------");

                return true;

            }

            int i = 0, k = -1;
         
            Console.Write("Enter Name : ");
            string ress = Console.ReadLine();
            foreach (Patient obj in pt)
            {
                if (obj._Name() == ress)
                {
                    k = i;
                }
                i++;
            }
            Console.WriteLine("---------Result-------------");
            if (k != -1)
            {
                pt.RemoveAt(k);
                Console.WriteLine("Deleted Succcessfull");
            }
            else
            {
                Console.WriteLine("Name not found");
            }
            Console.WriteLine("------------------------");
                   
            return true;
        }

        public bool Updated(List<Patient> pt)
        {
            Console.WriteLine("Enter the name to Update the Details:");
            string sn = Console.ReadLine();
            int k = -1,i=0;
            foreach(Patient obj in pt)
            {
                if (obj._Name() == sn)
                {
                    k = i;
                    break;
                }
                i++;
            }
            try
            {
                if (k == -1) 
                throw new Myexception();
            }catch(Myexception e)
            {
                Console.WriteLine("-------------------------------");
                e.Notfound();
                Console.WriteLine("-------------------------------");

                return true;
            }


            if (k != -1)
            {
                Console.WriteLine("1: Update Name \n2:Update Address \n3:Update Room no:\n 4:Update Doctor-in-charge \n5:Disease");
                int n = int.Parse(Console.ReadLine());
                switch (n) {
                    case 1:
                        Console.Write("Enter Name: ");
                        pt[k].Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter Address: ");
                        pt[k].Address = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Enter Roomno: ");
                        pt[k].Roomno = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Enter Doctor-in-charge: ");
                        pt[k].Doccharge = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Enter Disease: ");
                        pt[k].Disease = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("----INVALID OPTION----"); 
                        return true;
                       

                }
                Console.WriteLine("Update successfully");


            }
            else
            {
                Console.WriteLine("Name Not found");
            }
            return true;

        }
   
    
    }
}
