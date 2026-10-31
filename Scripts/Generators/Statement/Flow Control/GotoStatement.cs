namespace Rusty.CSharpGenerator;

using Rusty.CSharpGenerator.Keywords;

/// <summary>
/// A continue statement generator.
/// </summary>
public sealed class GoToStatement : Statement
{
    /* Public properties. */
    public Identifier Name { get; set; } = new();

    /* Private properties. */
    private GoToKeyword Keyword { get; } = new();

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        Keyword.Generate(w);
        w.Space();
        Name.Generate(w);
        w.Append(';');
    }
}