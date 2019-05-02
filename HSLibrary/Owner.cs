using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    [DeviceAtribute("Owner")]
    public class Owner
    {
        string nameOwner;
        int ageOwner;
        int capitalOwner;
        public override string ToString()
        {
            return nameOwner;
        }
        public string NameOwner
        {
            get
            {
                return nameOwner;
            }
            set
            {
                nameOwner = value;
            }
        }
        public int AgeOwner
        {
            get
            {
                return ageOwner;
            }
            set
            {
                ageOwner = value;
            }
        }
        public int CapitalOwner
        {
            get
            {
                return capitalOwner;
            }
            set
            {
                capitalOwner = value;
            }
        }
    }
}
