namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A bitwise OR expression generator.
/// </summary>
public sealed class BitwiseOrExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override BitwiseOrOperator Operator => new();
}