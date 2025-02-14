namespace CSharpier.SyntaxPrinter.SyntaxNodePrinters;

internal static class ThrowStatement
{
    public static Doc Print(ThrowStatementSyntax node)
    {
        var expression =
            node.Expression != null ? Doc.Concat(" ", Node.Print(node.Expression)) : string.Empty;
        return Doc.Concat(
            ExtraNewLines.Print(node),
            Token.Print(node.ThrowKeyword),
            expression,
            Token.Print(node.SemicolonToken)
        );
    }
}
