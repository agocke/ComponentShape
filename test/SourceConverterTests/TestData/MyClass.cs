using System.ComponentModel;
using System.Globalization;

namespace SourceConverter.Tests;

[TypeConverter(typeof(MyClassConverter))]
partial class MyClass {
    // Insert code here.
}

partial class MyClassConverter : TypeConverter
{
    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        if (destinationType == typeof(string))
            return "abc";
        return base.ConvertTo(context, culture, value, destinationType);
    }
}