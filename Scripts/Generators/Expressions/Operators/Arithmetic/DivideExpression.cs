namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A divide expression generators.
/// </summary>
public sealed class DivideExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override DivideOperator Operator => new();
}