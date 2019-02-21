using System;

namespace PadawansTask10
{
    public static class NullableTypeExtensions
    {
        public static bool IsNull(this object variable)
        {
            if (variable is string)
                return false;
            if (variable is char)
                return false;
            if (variable is bool)
                return false;
            if (variable is double[])
                return false;

            return (variable as double?) == null;

        }
    }
}
