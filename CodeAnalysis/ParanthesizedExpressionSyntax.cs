namespace myCompiler.CodeAnalysis
{
    sealed class ParanthesizedExpressionSyntax : ExpressionSyntax
    {
        public ParanthesizedExpressionSyntax(SyntaxToken openParanthesisToken, ExpressionSyntax expression, SyntaxToken closeParanthesisToken)
        {
            OpenParanthesisToken = openParanthesisToken;
            Expression = expression;
            CloseParanthesisToken = closeParanthesisToken;
        }
        public SyntaxToken OpenParanthesisToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken CloseParanthesisToken { get; }

        public override SyntaxKind Kind => SyntaxKind.ParanthesizedExpressionSyntax;
        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return OpenParanthesisToken;
            yield return Expression;
            yield return CloseParanthesisToken;
        }
    }

}