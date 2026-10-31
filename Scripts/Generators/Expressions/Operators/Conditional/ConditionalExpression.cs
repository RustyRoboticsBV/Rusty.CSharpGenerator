namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A ternary conditional expression generator.
/// </summary>
public sealed class ConditionalExpression : TernaryOperatorExpression
{
    /* Protected properties. */
    protected override IfOperator Operator1 => new();
    protected override ElseOperator Operator2 => new();
}