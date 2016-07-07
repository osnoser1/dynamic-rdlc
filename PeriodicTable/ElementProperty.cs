namespace PeriodicTable
{
    public class ElementProperty
    {
        private static string group;
        private static string period;
        private static string atomicNumber;
        private static string state;
        private static string chemicalSymbol;
        private static string url;
        private static string name;
        private static string massUncertainty;
        private static string relativeAtomicMass;
        private static string naturalOccurrence;
        private static string countryOfDiscovery;
        private static string chemicalProperty;

        public static string Group
        {
            get
            {
                return group ?? (group = ReflectOn<Element>.GetProperty(p => p.Group).Name);
            }
        }

        public static string Period
        {
            get
            {
                return period ?? (period = ReflectOn<Element>.GetProperty(p => p.Period).Name);
            }
        }

        public static string AtomicNumber
        {
            get
            {
                return atomicNumber ?? (atomicNumber = ReflectOn<Element>.GetProperty(p => p.AtomicNumber).Name);
            }
        }

        public static string State
        {
            get
            {
                return state ?? (state = ReflectOn<Element>.GetProperty(p => p.State).Name);
            }
        }

        public static string ChemicalSymbol
        {
            get
            {
                return chemicalSymbol ?? (chemicalSymbol = ReflectOn<Element>.GetProperty(p => p.ChemicalSymbol).Name);
            }
        }

        public static string Url
        {
            get
            {
                return url ?? (url = ReflectOn<Element>.GetProperty(p => p.Url).Name);
            }
        }

        public static string Name
        {
            get
            {
                return name ?? (name = ReflectOn<Element>.GetProperty(p => p.Name).Name);
            }
        }

        public static string MassUncertainty
        {
            get
            {
                return massUncertainty
                       ?? (massUncertainty = ReflectOn<Element>.GetProperty(p => p.MassUncertainty).Name);
            }
        }

        public static string RelativeAtomicMass
        {
            get
            {
                return relativeAtomicMass
                       ?? (relativeAtomicMass = ReflectOn<Element>.GetProperty(p => p.RelativeAtomicMass).Name);
            }
        }

        public static string NaturalOccurrence
        {
            get
            {
                return naturalOccurrence
                       ?? (naturalOccurrence = ReflectOn<Element>.GetProperty(p => p.NaturalOccurrence).Name);
            }
        }

        public static string CountryOfDiscovery
        {
            get
            {
                return countryOfDiscovery
                       ?? (countryOfDiscovery = ReflectOn<Element>.GetProperty(p => p.CountryOfDiscovery).Name);
            }
        }

        public static string ChemicalProperty
        {
            get
            {
                return chemicalProperty
                       ?? (chemicalProperty = ReflectOn<Element>.GetProperty(p => p.ChemicalProperty).Name);
            }
        }
    }
}
