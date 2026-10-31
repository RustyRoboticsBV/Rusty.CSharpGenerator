namespace Rusty.CSharpGenerator.Expressions;

using Rusty.CSharpGenerator.Keywords;

/// <summary>
/// A bool value expression generator.
/// </summary>
public sealed class BoolValueExpression : Expression
{
    /* Public properties. */
    public bool Value { get; set; }

    /* Private properties. */
    public TrueKeyword True { get; } = new();
    public FalseKeyword False { get; } = new();

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        if (Value)
            True.Generate(w);
        else
            False.Generate(w);
    }
}