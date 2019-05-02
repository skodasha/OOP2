using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum headphoneOutput
    {
        type_Jack,
        type_miniJack,
        type_microJack,
        no
    }
    public enum wirelessCharging
    {
        yes,
        no
    }
    [DeviceAtribute("Smartphone")]
    public class Smartphone: SmartDevice
    {
        public headphoneOutput HeadphoneOutput { get; set; }
        public wirelessCharging WirelessCharging { get; set; }
    }
}
