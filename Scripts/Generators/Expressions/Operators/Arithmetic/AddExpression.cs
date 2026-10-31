namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// An add expression generator.
/// </summary>
public sealed class AddExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override PlusOperator Operator => new();
}