namespace Rusty.CSharpGenerator;

/// <summary>
/// A label generator.
/// </summary>
public sealed class Label : Statement
{
    /* Public properties. */
    public Identifier Name { get; set; } = new();

    /* Public methods. */
    public override void Generate(CodeWriter w)
    {
        Name.Generate(w);
        w.Append(':');
    }
}