using System;
using System.ComponentModel;

namespace Devices.Visa.Core;

public static class EnumExtensions
{
    public static string ToDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

        var result = attribute != null ? attribute.Description : string.Empty;

        return result;
    }
}