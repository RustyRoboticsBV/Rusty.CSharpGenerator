namespace Rusty.CSharpGenerator;

/// <summary>
/// A null-coalescing operator generator.
/// </summary>
public sealed class NullCoalescingOperator : Operator
{
    /* Public properties. */
    public override string Symbols => "??";
}