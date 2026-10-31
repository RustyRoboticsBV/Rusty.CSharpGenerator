namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// An int value expression generator.
/// </summary>
public sealed class IntValueExpression : Expression
{
    /* Public properties. */
    public int Value { get; set; }

    /* Public methods. */
    public override void Generate(CodeWriter w) => w.Append(Value.ToString());
}