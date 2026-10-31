namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// An identifier expression generator.
/// </summary>
public sealed class IdentifierExpression : Expression
{
    /* Public properties. */
    public Identifier Name { get; set; } = new();

    /* Public methods. */
    public override void Generate(CodeWriter w) => Name.Generate(w);
}