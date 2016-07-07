namespace PeriodicTable
{
    public class Element
    {
        public int Group { get; set; }

        public int Period { get; set; }

        public string Name { get; set; }

        public object AtomicNumber { get; set; }

        public string ChemicalSymbol { get; set; }

        public object RelativeAtomicMass { get; set; }

        public int MassUncertainty { get; set; }

        public ChemicalProperty ChemicalProperty { get; set; }

        public NaturalOccurrence NaturalOccurrence { get; set; }

        public CountryOfDiscovery CountryOfDiscovery { get; set; }

        public State State { get; set; }

        public string Url { get; set; }
    }
}