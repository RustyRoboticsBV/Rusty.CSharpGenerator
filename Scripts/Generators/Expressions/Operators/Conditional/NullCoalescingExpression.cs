namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A null coalescing expression generator.
/// </summary>
public sealed class NullCoalescingExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override NullCoalescingOperator Operator => new();
}