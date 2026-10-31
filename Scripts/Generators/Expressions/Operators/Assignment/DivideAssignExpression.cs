namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A divide-assign expression generator.
/// </summary>
public sealed class DivideAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override DivideAssignOperator Operator => new();
}