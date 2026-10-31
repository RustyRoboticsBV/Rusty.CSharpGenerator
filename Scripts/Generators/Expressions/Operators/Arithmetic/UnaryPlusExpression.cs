namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A unary plus expression generators.
/// </summary>
public sealed class UnaryPlusExpression : UnaryOperatorExpression
{
    /* Protected properties. */
    protected override PlusOperator Operator => new();
}