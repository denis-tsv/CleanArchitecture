using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CleanArchitectureAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class CleanArchitectureDiagnosticAnalyzer : DiagnosticAnalyzer
    {
        private readonly List<(string From, string To)> _wrongReferences = new List<(string, string)>
        {
            //nuget packages
            ( "Entities", "EntityFramework"), 

            //projects
            ( "UseCases", "DataAccess"),
            ( "UseCases", "Infrastructure.Implementation"),
            ( "UseCases", "DomainServices.Implementation"),

            ("Controllers", "DataAccess"),
            ("Controllers", "Infrastructure.Interfaces"),
            ("Controllers", "DomainServices.Interfaces"),
            ("Controllers", "Infrastructure.Implementation"),
            ("Controllers", "DomainServices.Implementation"),

            ("Infrastructure.Implementation", "DomainServices.Implementation"),

        };

        private const string Category = "InvalidReference";

        private static readonly DiagnosticDescriptor CrossLevelReference = new DiagnosticDescriptor("CrosLvl", "Cross-level reference", "Cross-level reference", Category, DiagnosticSeverity.Error, isEnabledByDefault: true, description: "Cross-level reference");

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(CrossLevelReference);

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.UsingDirective);
        }

        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            var namespaceName = ((UsingDirectiveSyntax)context.Node).Name.ToString();
            var assemblyName = context.Compilation.AssemblyName;
            
            foreach (var layer in _wrongReferences)
            {
                if (assemblyName.Contains(layer.From) && namespaceName.Contains(layer.To))
                {
                    context.ReportDiagnostic(Diagnostic.Create(CrossLevelReference, context.Node.GetLocation()));
                }
            }
        }
    }
}
