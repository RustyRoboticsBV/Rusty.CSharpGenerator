namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// An add-assign expression generator.
/// </summary>
public sealed class AddAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override AddAssignOperator Operator => new();
}