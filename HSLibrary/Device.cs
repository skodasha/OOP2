using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum manufacturer
    {
        Apple,
        Samsung,
        Xiaomi,
        Huawei,
        Asus
    }
     
    public abstract class Device
    {
        int cost; 
        int warranty;
        public Owner Owner { get; set; }
              
        public int Warranty
        {
            get
            {
                return warranty;
            }
            set
            {
                warranty = value;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        
        public manufacturer Manufacturer { get; set; }
    }
}
