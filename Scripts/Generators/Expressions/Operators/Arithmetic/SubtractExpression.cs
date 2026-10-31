namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A subtract expression generators.
/// </summary>
public sealed class SubtractExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override MinusOperator Operator => new();
}