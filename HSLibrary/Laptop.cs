using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum floppyDisk
    {
        yes,
        no
    }
    [DeviceAtribute("Laptop")]
    public class Laptop: Computer
    {
        Double weight;
        public Double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public floppyDisk FloppyDisk { get; set; }

    }
}
