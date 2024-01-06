

using System.Runtime.Serialization;

internal sealed class SR
{
    internal static string Collection => nameof(Collection);
    internal static string toStringNone => nameof(toStringNone);

    public static string TypeDescriptorProviderError => nameof(TypeDescriptorProviderError);
    public static string TypeDescriptorSameAssociation => nameof(TypeDescriptorSameAssociation);
    public static string TypeDescriptorAlreadyAssociated => nameof(TypeDescriptorAlreadyAssociated);
    public static string TypeDescriptorArgsCountMismatch => nameof(TypeDescriptorArgsCountMismatch);
    public static string ConvertInvalidPrimitive => nameof(ConvertInvalidPrimitive);
    public static string TypeDescriptorExpectedElementType => nameof(TypeDescriptorExpectedElementType);

    public static string Null => nameof(Null);

    public static string InvalidNullArgument => nameof(InvalidNullArgument);
    public static string ErrorInvalidEventType => nameof(ErrorInvalidEventType);
    public static string ConvertFromException => nameof(ConvertFromException);
    public static string ConvertToException => nameof(ConvertToException);
    public static string ErrorInvalidEventHandler => nameof(ErrorInvalidEventHandler);
    public static string ErrorPropertyAccessorException => nameof(ErrorPropertyAccessorException);
    public static string ErrorInvalidPropertyType => nameof(ErrorInvalidPropertyType);
    public static string EnumConverterInvalidValue => nameof(EnumConverterInvalidValue);
    public static string MetaExtenderName => nameof(MetaExtenderName);
    public static string ErrorMissingPropertyAccessors => nameof(ErrorMissingPropertyAccessors);
    public static string ErrorMissingEventAccessors => nameof(ErrorMissingEventAccessors);
    public static string InvalidMemberName => nameof(InvalidMemberName);
    public static string Array => nameof(Array);
    public static string NullableConverterBadCtorArg => nameof(NullableConverterBadCtorArg);

    internal static string Format(string formatString, params object?[] args)
    {
        throw new NotImplementedException();
    }

    internal static bool UsingResourceKeys()
    {
        throw new NotImplementedException();
    }
}