namespace Rusty.CSharpGenerator.Expressions;

using Rusty.CSharpGenerator.Keywords;

/// <summary>
/// A string value expression generator.
/// </summary>
public sealed class StringValueExpression : Expression
{
    /* Public properties. */
    public string Value { get; set; }
    public bool Interpolated { get; set; }

    /* Private properties. */
    private NullKeyword Null { get; } = new();

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        if (Value == null)
            Null.Generate(w);

        else
        {
            if (Interpolated)
                w.Append('$');
            w.Append('"');
            w.Append(Value.Replace("\"", "\\\""));
            w.Append('"');
        }
    }
}