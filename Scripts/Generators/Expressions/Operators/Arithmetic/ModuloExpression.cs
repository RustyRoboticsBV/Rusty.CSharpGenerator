namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A modulo expression generators.
/// </summary>
public sealed class ModuloExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override ModuloOperator Operator => new();
}