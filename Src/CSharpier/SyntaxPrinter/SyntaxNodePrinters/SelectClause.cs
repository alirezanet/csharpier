namespace CSharpier.SyntaxPrinter.SyntaxNodePrinters;

internal static class SelectClause
{
    public static Doc Print(SelectClauseSyntax node)
    {
        return Doc.Concat(
            Token.PrintWithSuffix(node.SelectKeyword, " "),
            Node.Print(node.Expression)
        );
    }
}
