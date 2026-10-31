namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A unsigned right bitshift-assign expression generator.
/// </summary>
public sealed class UnsignedBitshiftRightAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override UnsignedBitshiftRightAssignOperator Operator => new();
}