using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Max.Tests
{
    public class CleanArchitectureTests
    {
        [Fact]
        public void CrossLayerReferences()
        {
            var wrongReferences = new List<(string From, string To)>
            {
                ("UseCases", "DataAccess"),
                ("UseCases", "Infrastructure.Implementation"),
                ("UseCases", "DomainServices.Implementation"),

                ("Controllers", "DataAccess"),
                ("Controllers", "Infrastructure.Interfaces"),
                ("Controllers", "DomainServices.Interfaces"),
                ("Controllers", "Infrastructure.Implementation"),
                ("Controllers", "DomainServices.Implementation"),

                ("Infrastructure.Implementation", "DomainServices.Implementation"),
            };

            var hostAssembly = Assembly.Load("Max.Web");
            var assemblies = hostAssembly
                .GetReferencedAssemblies()
                .Where(x => x.Name.StartsWith("Max"))
                .Select(Assembly.Load)
                .ToList();
            assemblies.Add(hostAssembly);

            foreach (var layer in wrongReferences)
            {
                foreach (var assembly in assemblies)
                {
                    foreach (var reference in assembly.GetReferencedAssemblies())
                    {
                        Assert.False(assembly.FullName.Contains(layer.From) && reference.FullName.Contains(layer.To),
                            $"Cross-layer reference from '{assembly.FullName}' to '{reference.FullName}'");
                    }
                }
            }
        }
    }
}
