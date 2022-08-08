using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionExcersice
{
    class Furniture
    {

        int _Orderid, _Orderdate, _Qty, _Amount;
        string _Furnituretype, _Paymentmode;

        public Furniture(){

        }
        public Furniture(int _Orderid, int _Orderdate, int _Qty, int _Amount, string _Furnituretype, string _Paymentmode)
        {
            this._Amount = _Amount; 
            this._Orderid = _Orderid;
            this._Qty = _Qty;
            this._Furnituretype = _Furnituretype;
            this._Paymentmode = _Paymentmode;
        }
        public int Gorderid()
        {
            return _Orderid;
        }
        public void Sorderid(int a)
        {
            _Orderid = a;
        }
        public void Sftype(string a)
        {
            
            _Furnituretype = a;
        }
        public void Spay(string n)
        {
            _Paymentmode = n;
        }
        public string Gftype()
        {
            return _Furnituretype;
        }
        public string Gpay()
        {
            return _Paymentmode;
        }
        public int Gamount()
        {
            return _Amount;
        }
        
        public int Gqty()
        {
            return _Qty;
        }

        public void Samount(int a)
        {
            this._Amount = a;
        }
        public void Sqty(int a)
        {
            this._Qty = a;
        }
       


    }

    class Chair:Furniture
    {
        string _Chttype;
        int _rate, _Chcapacity;
        public Chair()
        {

        }
        public Chair(string _Chttype,int _Chcapacity, int _rate)
        {
            this._Chttype = _Chttype;
            this._rate = _rate;
            this._Chcapacity = _Chcapacity;
        }
        public string Gchtype()
        {
            return _Chttype;
        }
        public int Gchcapacity()
        {
            return _Chcapacity;
        }
        public int Grate()
        {
            return _rate;
        }

        public void Schtype(string a)
        {
            _Chttype = a;
        }
        public void Schcapacity(int a)
        {
            _Chcapacity = a;
        }
        public void Srate(int a)
        {
            _rate= a;
        }


    }
    class Cot : Furniture
    {
        string _Chttype;
        int _rate, _Chcapacity;
        public Cot()
        {

        }
        public Cot(string _Chttype, int _Chcapacity, int _rate)
        {
            this._Chttype = _Chttype;
            this._rate = _rate;
            this._Chcapacity = _Chcapacity;
        }
        public string Gchtype()
        {
            return _Chttype;
        }
        public int Gchcapacity()
        {
            return _Chcapacity;
        }
        public int Grate()
        {
            return _rate;
        }

        public void Schtype(string a)
        {
            _Chttype = a;
        }
        public void Schcapacity(int a)
        {
            _Chcapacity = a;
        }
        public void Srate(int a)
        {
            _rate = a;
        }



    }


}
