namespace Rusty.CSharpGenerator;

/// <summary>
/// A null-coalescing assign operator generator.
/// </summary>
public sealed class NullCoalescingAssignOperator : Operator
{
    /* Public properties. */
    public override string Symbols => "??=";
}