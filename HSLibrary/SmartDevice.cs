using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum bluetooth
    {
        yes,
        no
    }
    [DeviceAtribute("SmartDevice")]
    public class SmartDevice: Device
    {
        int battery;
        public int Battery
        {
            get
            {
                return battery;
            }
            set
            {
                battery = value;
            }
        }
        public bluetooth Bluetooth { get; set; }
    }
}
