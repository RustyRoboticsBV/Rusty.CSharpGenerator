namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A modulo-assign expression generator.
/// </summary>
public sealed class ModuloAssignExpression : BinaryOperatorExpression
{
    /* Protected properties. */
    protected override ModuloAssignOperator Operator => new();
}