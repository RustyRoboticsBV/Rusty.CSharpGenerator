namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A right bitshift-assign expression generator.
/// </summary>
public sealed class BitshiftRightAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override BitshiftRightAssignOperator Operator => new();
}