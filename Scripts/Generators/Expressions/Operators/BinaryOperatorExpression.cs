namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A base class for binary operator generators.
/// </summary>
public abstract class BinaryOperatorExpression : OperatorExpression
{
    /* Public properties. */
    public Expression Operand1 { get; set; }
    public Expression Operand2 { get; set; }

    /* Protected properties. */
    protected abstract Operator Operator { get; }

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        GenerateChild(Operand1, w);
        w.Space();
        Operator.Generate(w);
        w.Space();
        GenerateChild(Operand2, w);
    }
}