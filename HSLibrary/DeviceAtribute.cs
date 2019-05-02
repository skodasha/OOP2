using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    class DeviceAtribute : Attribute
    {
        public string NameDevice { get; set; }

        public DeviceAtribute() { }
        public DeviceAtribute(string nameDevice)
        {
            NameDevice = nameDevice;
        }

        public override string ToString()
        {
            return $"{NameDevice}";
        }
    }
}
