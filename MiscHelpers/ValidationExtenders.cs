using System.Runtime.CompilerServices;

namespace MiscHelpers;

public static class ValidationExtenders
{
    public static T ThrowIfNull<T>(this T value, 
        [CallerArgumentExpression(nameof(value))] string argName = null!)
        where T : class
    {
        if (value is null)
        {
            throw new ValidationException(
                $"The \"{argName}\" field may not be NULL!");
        }

        return value;
    }
}