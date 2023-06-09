namespace Foundation.Infrastructure.Find.Facets
{
    public class FacetRegistry : IFacetRegistry
    {
        private List<FacetDefinition> _facetDefinitions;

        public FacetRegistry() : this(new List<FacetDefinition>())
        {
        }

        public FacetRegistry(IEnumerable<FacetDefinition> facetDefinitions) => _facetDefinitions = facetDefinitions.ToList();

        public void Clear()
        {
            _facetDefinitions.Clear();
        }

        public List<FacetDefinition> GetFacetDefinitions() => _facetDefinitions;

        public void AddFacetDefinitions(FacetDefinition facetDefinition) => _facetDefinitions.Add(facetDefinition);

        public bool RemoveFacetDefinitions(FacetDefinition facetDefinition) => _facetDefinitions.Remove(facetDefinition);
    }
}