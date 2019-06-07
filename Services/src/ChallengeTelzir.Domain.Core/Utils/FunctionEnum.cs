using System;
using System.ComponentModel;

namespace ChallengeTelzir.Domain.Core.Utils
{
    public static class FunctionEnum
    {
        public static string GetEnumDescription(Enum value)
        {
            if (value == null) return null;

            var fi = value.GetType().GetField(value.ToString());

            if (fi == null) return null;

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            return value.ToString();
        }
    }
}