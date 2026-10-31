namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A multiply expression generators.
/// </summary>
public sealed class MultiplyExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override MultiplyOperator Operator => new();
}