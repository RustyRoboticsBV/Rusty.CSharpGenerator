namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A base class for ternary operator generators.
/// </summary>
public abstract class TernaryOperatorExpression : OperatorExpression
{
    /* Public properties. */
    public Expression Operand1 { get; set; }
    public Expression Operand2 { get; set; }
    public Expression Operand3 { get; set; }

    /* Protected properties. */
    protected abstract Operator Operator1 { get; }
    protected abstract Operator Operator2 { get; }

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        GenerateChild(Operand1, w);
        w.Space();
        Operand1.Generate(w);
        w.Space();
        GenerateChild(Operand2, w);
        w.Space();
        Operand2.Generate(w);
        w.Space();
        GenerateChild(Operand3, w);
    }
}