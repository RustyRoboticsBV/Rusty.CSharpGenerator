namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A char value expression generator.
/// </summary>
public sealed class CharValueExpression : Expression
{
    /* Public properties. */
    public char Value { get; set; }

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        w.Append('\'');
        if (Value == '\'')
            w.Append('\\');
        w.Append(Value);
        w.Append('\'');
    }
}