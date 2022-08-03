using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Laptop
    {
        #region Parameters
        string _lapname;
        int _modelid;
        float _amount;
        byte _ram;
        #endregion
        #region constructor
        public Laptop()
        { 
        }
        public Laptop(string lapname, int modelid, float amount, byte ram)
        {
            this._lapname = lapname;
            this._modelid = modelid;
            this._amount = amount;
            this._ram = ram;
        }
        #endregion

        #region Properties

        public void status()
        {
            Console.WriteLine(this._lapname);
            Console.WriteLine(this._modelid);
            Console.WriteLine(this._amount);
            Console.WriteLine(this._ram);
        }

        public string GetLaptopName()
        {
            return _lapname;
        }
        public int GetModelNumber()
        {
            return _modelid;
        }
        public float GetAmount()
        {
            return _amount;
        }
        public byte GetRam()
        {
            return _ram;    
        }
        #endregion
        public void SetLaptopName(string s)
        {
            if (s.Length != 0)
                this._lapname = s;
        }

        public void SetAmount(float s)
        {
            if (s != 0)
            {
                this._amount = s;
            }
        }
        public void SetModelNumber(int s)
        {
            if (s != 0) this._modelid = s;
        }
        public void SetRam(byte s)
        {
            if (s != 0) this._ram = s;
        }

    }

}
