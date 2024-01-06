// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Globalization;

namespace ComponentShape
{
    /// <summary>
    /// Provides a type converter to convert 32-bit signed integer objects to and
    /// from various other representations.
    /// </summary>
    public class Int32Converter : BaseNumberConverter
    {
        /// <summary>
        /// The Type this converter is targeting (e.g. Int16, UInt32, etc.)
        /// </summary>
        internal override Type TargetType => typeof(int);

        /// <summary>
        /// Convert the given value to a string using the given radix
        /// </summary>
        internal override object FromString(string value, int radix) => Convert.ToInt32(value, radix);

        /// <summary>
        /// Convert the given value to a string using the given formatInfo
        /// </summary>
        internal override object FromString(string value, NumberFormatInfo? formatInfo)
        {
            return int.Parse(value, NumberStyles.Integer, formatInfo);
        }

        /// <summary>
        /// Convert the given value from a string using the given formatInfo
        /// </summary>
        internal override string ToString(object value, NumberFormatInfo? formatInfo)
        {
            return ((int)value).ToString("G", formatInfo);
        }
    }
}