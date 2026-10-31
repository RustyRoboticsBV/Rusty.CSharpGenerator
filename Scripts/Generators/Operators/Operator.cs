namespace Rusty.CSharpGenerator;

/// <summary>
/// A base class for operator generators.
/// </summary>
public abstract class Operator : Generator
{
    /* Public properties. */
    public abstract string Symbols { get; }

    /* Public methods. */
    public override void Generate(CodeWriter w) => w.Append(Symbols);
}