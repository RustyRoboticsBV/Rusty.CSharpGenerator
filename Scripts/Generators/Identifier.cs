namespace Rusty.CSharpGenerator;

/// <summary>
/// An identifier name generator.
/// </summary>
public sealed class Identifier : Generator
{
    /* Public properties. */
    public string Name { get; set; } = "";

    /* Public methods. */
    public override void Generate(CodeWriter w) => w.Append(Name);
}