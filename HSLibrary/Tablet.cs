using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum screen3d
    {
        yes,
        no
    }
    public enum accessSIM
    {
        mini,
        micro,
        nano,
        no
    }

    [DeviceAtribute("Tablet")]
    public class Tablet: SmartDevice
    {
        public screen3d Screen3D { get; set; }
        public accessSIM AccessSIM { get; set; }
    }
}
