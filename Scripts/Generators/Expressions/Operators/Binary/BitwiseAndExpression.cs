namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A bitwise AND expression generator.
/// </summary>
public sealed class BitwiseAndExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override BitwiseAndOperator Operator => new();
}