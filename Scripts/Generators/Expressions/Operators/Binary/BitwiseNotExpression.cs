namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A bitwise NOT expression generator.
/// </summary>
public sealed class BitwiseNotExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override BitwiseNotOperator Operator => new();
}