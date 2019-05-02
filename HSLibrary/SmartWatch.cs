using System;
using System.Collections.Generic;
using System.Text;

namespace HSLibrary
{
    public enum alarm
    {
        yes,
        no
    }
    public enum pulseMonitor
    {
        yes,
        no
    }
    public enum pedometr
    {
        yes,
        no
    }
    [DeviceAtribute("SmartWatch")]
    public class SmartWatch : SmartDevice
    {
        public alarm Alarm { get; set; }
        public pulseMonitor PulseMonitor { get; set; }
        public pedometr Pedometr { get; set; }

    }
}
