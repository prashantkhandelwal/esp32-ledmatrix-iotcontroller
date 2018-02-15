using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESP32_LEDController
{
    public class Global
    {
        public static string ConnectionString { get; set; }
        public static string DeviceId { get; set; }
        public static bool IsAuto { get; set; }
        public static bool IsMaual { get; set; }
        public static int LedLoc { get; set; }
        public static string R { get; set; } = "255";
        public static string G { get; set; } = "255";
        public static string B { get; set; } = "255";
     
        public static bool ValidateSettings()
        {
            bool IsValid = false;
            if (!String.IsNullOrEmpty(ConnectionString) || !String.IsNullOrEmpty(DeviceId))
            {
                IsValid = true;
            }

            return IsValid;
        }
    }
}
