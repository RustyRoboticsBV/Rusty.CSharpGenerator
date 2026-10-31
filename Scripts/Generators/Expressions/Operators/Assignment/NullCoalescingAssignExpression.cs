namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A null-coalescing assign expression generator.
/// </summary>
public sealed class NullCoalescingAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override NullCoalescingAssignOperator Operator => new();
}