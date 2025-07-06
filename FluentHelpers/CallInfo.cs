namespace CommonRoslynHelpersLibrary.FluentHelpers;
public struct CallInfo
{
    public InvocationExpressionSyntax Invocation;
    public IMethodSymbol MethodSymbol;
    public ArgumentListSyntax ArgumentList;
}