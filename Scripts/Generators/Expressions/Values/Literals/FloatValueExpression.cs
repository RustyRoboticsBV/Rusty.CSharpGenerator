namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A float value expression generator.
/// </summary>
public sealed class FloatValueExpression : Expression
{
    /* Public properties. */
    public decimal Value { get; set; }

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        w.Append(Value.ToString());
        w.Append('f');
    }
}