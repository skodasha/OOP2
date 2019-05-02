using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum cpu
    {
        IntelCorei9,
        IntelCorei7,
        IntelCorei5,
        IntelCorei3,
        IntelCorem3,
        IntelCorem5,
        IntelCorem7,

    }
    [DeviceAtribute("Computer")]
    public class Computer: Device
    {
        int ram;
        int displaysize;
        public int Ram
        {
            get
            {
                return ram;
            }
            set
            {
                ram = value;
            }
        }
        
        public int Displaysize
        {
            get
            {
                return displaysize;
            }
            set
            {
                displaysize = value;
            }
        }
        public cpu Cpu { get; set; }
    }
}
