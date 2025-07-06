namespace CommonRoslynHelpersLibrary.FluentHelpers;
public sealed class ParseContext(Compilation compilation, SyntaxNode syntax)
{
    public Compilation Compilation { get; } = compilation;
    public SemanticModel SemanticModel { get; } = syntax.GetSemanticModel(compilation);
}