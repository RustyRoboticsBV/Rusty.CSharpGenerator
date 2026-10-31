namespace Rusty.CSharpGenerator.Keywords;

/// <summary>
/// A base class for keyword generators.
/// </summary>
public abstract class Keyword : Generator
{
    /* Public properties. */
    public override bool SingleLine => true;

    public abstract string Name { get; }

    /* Public methods. */
    public override void Generate(CodeWriter w) => w.Append(Name);
}