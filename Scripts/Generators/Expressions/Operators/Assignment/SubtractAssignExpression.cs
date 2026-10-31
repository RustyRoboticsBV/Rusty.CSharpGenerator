namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// An subtract-assign expression generator.
/// </summary>
public sealed class SubtractAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override SubtractAssignOperator Operator => new();
}