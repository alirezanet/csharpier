namespace CSharpier.SyntaxPrinter.SyntaxNodePrinters;

internal static class CheckedExpression
{
    public static Doc Print(CheckedExpressionSyntax node)
    {
        return Doc.Concat(
            Token.Print(node.Keyword),
            Doc.Group(
                Token.Print(node.OpenParenToken),
                Doc.Indent(Doc.SoftLine, Node.Print(node.Expression)),
                Doc.SoftLine,
                Token.Print(node.CloseParenToken)
            )
        );
    }
}
