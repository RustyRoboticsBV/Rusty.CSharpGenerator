namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A left bitshift-assign expression generator.
/// </summary>
public sealed class BitshiftLeftAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override BitshiftLeftAssignOperator Operator => new();
}