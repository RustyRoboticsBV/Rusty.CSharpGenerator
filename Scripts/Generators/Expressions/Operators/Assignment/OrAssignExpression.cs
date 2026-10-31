namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A bitwise OR-assign expression generator.
/// </summary>
public sealed class OrAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override OrAssignOperator Operator => new();
}