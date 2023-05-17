using FluentAssertions;
using MiscHelpers;

namespace UnitTests;

public class ValidationExtendersTests
{
    [Fact]
    public void ThrowIfNull_WithNullInput_ThrowsValidationExceptioon()
    {
        FluentActions.Invoking(() => ((string)null!).ThrowIfNull())
            .Should().Throw<ValidationException>();
    }

    [Fact]
    public void ThrowIfNull_WithValidInput_ReturnsValueUnchanged() =>
        "ABC".ThrowIfNull().Should().Be("ABC");
}