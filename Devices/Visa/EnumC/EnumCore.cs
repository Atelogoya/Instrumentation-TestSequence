using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Visa.EnumC
{
    public static class EnumCore
    {
        public static string ToDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            var result = attribute != null ? attribute.Description : string.Empty;

            return result;
        }
    }
}
