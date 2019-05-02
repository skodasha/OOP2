using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum bodyLight
    {
        yes,
        no
    }
    [DeviceAtribute("PersonalComputer")]
    public class PersonalComputer: Computer
    {
        int powerSupply;
        public int PowerSupply
        {
            get
            {
                return powerSupply;
            }
            set
            {
                powerSupply = value;
            }
        }
        public bodyLight BodyLight { get; set; }
    }
}
