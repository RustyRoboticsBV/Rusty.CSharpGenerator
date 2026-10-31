namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A multiply-assign expression generator.
/// </summary>
public sealed class MultiplyAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override MultiplyAssignOperator Operator => new();
}