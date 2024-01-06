using System.ComponentModel;
using System.Globalization;
using Xunit;

namespace SourceConverter.Tests;

public partial class UnitTest1
{
    [Fact]
    public void Original()
    {
        var m = new MyClass();
        var s = TypeDescriptor.GetConverter(typeof(MyClass)).ConvertToString(m);
        Assert.Equal("abc", s);
    }

    [Fact]
    public void SourceGen()
    {
        //var m = new MyClass();
        //var s = SourceConverter.GetTypeConverter<MyClass>().ConvertToString(m);
        //Assert.Equal("abc", s);
    }

}