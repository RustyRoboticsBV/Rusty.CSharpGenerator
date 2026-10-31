namespace Rusty.CSharpGenerator.Expressions;

/// <summary>
/// A base class for operator generators.
/// </summary>
public abstract class OperatorExpression : Expression
{
    /* Protected properties. */
    protected virtual bool RequiresParenthesesWhenNested => true;

    /* Protected methods. */
    protected static void GenerateChild(Expression expression, CodeWriter w)
    {
        if (expression is OperatorExpression @operator && @operator.RequiresParenthesesWhenNested)
        {
            w.Append('(');
            expression.Generate(w);
            w.Append(')');
        }
        else
            expression.Generate(w);
    }
}