namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A unary minus expression generators.
/// </summary>
public sealed class UnaryMinusExpression : UnaryOperatorExpression
{
    /* Protected properties. */
    protected override MinusOperator Operator => new();
}