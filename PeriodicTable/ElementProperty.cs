namespace PeriodicTable
{
    public class ElementProperty
    {
        private static string _group;
        private static string _period;
        private static string _atomicNumber;
        private static string _state;
        private static string _chemicalSymbol;
        private static string _url;
        private static string _name;
        private static string _massUncertainty;
        private static string _relativeAtomicMass;
        private static string _naturalOccurrence;
        private static string _countryOfDiscovery;
        private static string _chemicalProperty;

        public static string Group
        {
            get { return _group ?? (_group = ReflectOn<Element>.GetProperty(p => p.Group).Name); }
        }

        public static string Period
        {
            get { return _period ?? (_period = ReflectOn<Element>.GetProperty(p => p.Period).Name); }
        }

        public static string AtomicNumber
        {
            get { return _atomicNumber ?? (_atomicNumber = ReflectOn<Element>.GetProperty(p => p.AtomicNumber).Name); }
        }

        public static string State
        {
            get { return _state ?? (_state = ReflectOn<Element>.GetProperty(p => p.State).Name); }
        }

        public static string ChemicalSymbol
        {
            get
            {
                return _chemicalSymbol ?? (_chemicalSymbol = ReflectOn<Element>.GetProperty(p => p.ChemicalSymbol).Name);
            }
        }

        public static string Url
        {
            get { return _url ?? (_url = ReflectOn<Element>.GetProperty(p => p.Url).Name); }
        }

        public static string Name
        {
            get { return _name ?? (_name = ReflectOn<Element>.GetProperty(p => p.Name).Name); }
        }

        public static string MassUncertainty
        {
            get
            {
                return _massUncertainty
                       ?? (_massUncertainty = ReflectOn<Element>.GetProperty(p => p.MassUncertainty).Name);
            }
        }

        public static string RelativeAtomicMass
        {
            get
            {
                return _relativeAtomicMass
                       ?? (_relativeAtomicMass = ReflectOn<Element>.GetProperty(p => p.RelativeAtomicMass).Name);
            }
        }

        public static string NaturalOccurrence
        {
            get
            {
                return _naturalOccurrence
                       ?? (_naturalOccurrence = ReflectOn<Element>.GetProperty(p => p.NaturalOccurrence).Name);
            }
        }

        public static string CountryOfDiscovery
        {
            get
            {
                return _countryOfDiscovery
                       ?? (_countryOfDiscovery = ReflectOn<Element>.GetProperty(p => p.CountryOfDiscovery).Name);
            }
        }

        public static string ChemicalProperty
        {
            get
            {
                return _chemicalProperty
                       ?? (_chemicalProperty = ReflectOn<Element>.GetProperty(p => p.ChemicalProperty).Name);
            }
        }
    }
}