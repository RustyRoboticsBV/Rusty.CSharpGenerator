namespace Rusty.CSharpGenerator;

using Rusty.CSharpGenerator.Keywords;

/// <summary>
/// A break statement generator.
/// </summary>
public sealed class BreakStatement : Statement
{
    /* Private properties. */
    private BreakKeyword Keyword { get; } = new();

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        Keyword.Generate(w);
        w.Append(';');
    }
}