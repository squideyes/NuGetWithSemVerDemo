using MiscHelpers;

try
{
    string value = null!;

    Console.Write(value.ThrowIfNull());
}
catch (ValidationException error)
{
    Console.WriteLine(error.Message);
}