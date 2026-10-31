namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A base class for unary operator generators.
/// </summary>
public abstract class UnaryOperatorExpression : OperatorExpression
{
    /* Public properties. */
    public Expression Operand { get; set; }

    /* Protected properties. */
    protected abstract Operator Operator { get; }

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        Operator.Generate(w);
        GenerateChild(Operand, w);
    }
}