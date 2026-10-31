namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// An assign expression generator.
/// </summary>
public sealed class AssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override AssignOperator Operator => new();
}