namespace CommonRoslynHelpersLibrary.FluentHelpers;
internal struct CallInfo
{
    public InvocationExpressionSyntax Invocation;
    public IMethodSymbol MethodSymbol;
    public ArgumentListSyntax ArgumentList;
}