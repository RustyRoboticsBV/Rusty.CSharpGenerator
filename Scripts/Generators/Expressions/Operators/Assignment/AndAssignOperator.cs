namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A bitwise AND-assign expression generator.
/// </summary>
public sealed class AndAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override AndAssignOperator Operator => new();
}