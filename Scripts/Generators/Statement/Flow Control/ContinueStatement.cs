namespace Rusty.CSharpGenerator;

using Rusty.CSharpGenerator.Keywords;

/// <summary>
/// A continue statement generator.
/// </summary>
public sealed class ContinueStatement : Statement
{
    /* Private properties. */
    private ContinueKeyword Keyword { get; } = new();

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        Keyword.Generate(w);
        w.Append(';');
    }
}