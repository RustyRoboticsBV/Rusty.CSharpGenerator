namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// An is expression generator.
/// </summary>
public sealed class IsExpression : BinaryOperatorExpression
{
    /* Public properties. */
    public Identifier Type { get; set; }

    /* Protected properties. */
    protected override IsOperator Operator => new();
}