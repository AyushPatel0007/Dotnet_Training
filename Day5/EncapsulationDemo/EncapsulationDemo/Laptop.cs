using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationDemo
{
    /// <summary>
    /// Class Laptop 
    /// </summary>
    class Laptop
    {
        #region Data Fields
        string _laptopName;
         int _modelNumber;
         float _amount;
         byte _ram;
        #endregion

        #region constructors
        /// <summary>
        /// Constructor
        /// </summary>
        public Laptop()
        {

        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="laptopName"></param>
        /// <param name="modelNumber"></param>
        /// <param name="amount"></param>
        /// <param name="ram"></param>
        public Laptop(string laptopName, int modelNumber, float amount, byte ram)
        {
            
            this._laptopName = laptopName;
            this._modelNumber = modelNumber;
            this._amount= amount;
            this._ram = ram;
        }
        #endregion
        #region properties
        public string GetLaptopName()
        {
            return _laptopName;
        }      
        public int GetModelNumber()
        {
            return _modelNumber;
        }
        public float GetAmount()
        {
            return _amount;
        }
        public byte GetRam()
        {
            return _ram;
        }    
        /// <summary>
        /// method to check the length of the laptop Name
        /// </summary>
        /// <param name="laptopName"></param>
        public void SetLaptopName(string laptopName)
        {
            if(laptopName.Length != 0)
            {
                this._laptopName = laptopName;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelNumber"></param>
        public void SetModelNumber(int modelNumber)
        {
            if (modelNumber != 0)
            {
                this._modelNumber = modelNumber;
            }
        }
        public void SetAmount(float amount)
        {
            if(amount != 0)
            {
                this._amount = amount;
            }
        }
        public void SetRam(byte ram)
        {
            if (ram != 0)
            {
                this._ram = ram;
            }
        }



        #endregion

    }
}
