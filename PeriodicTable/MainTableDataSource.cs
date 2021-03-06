﻿using System.Collections.ObjectModel;

namespace PeriodicTable
{
    public class MainTableDataSource
    {
        public static Collection<Element> Create()
        {
            return new Collection<Element>
            {
                new Element
                {
                    Group = 1,
                    Period = 1,
                    Name = "Hydrogen",
                    AtomicNumber = 1,
                    ChemicalSymbol = "H",
                    RelativeAtomicMass = 1.00794,
                    MassUncertainty = 7,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.DiatomicNonmetal,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Hydrogen",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 18,
                    Period = 1,
                    Name = "Helium",
                    AtomicNumber = 2,
                    ChemicalSymbol = "He",
                    RelativeAtomicMass = 4.002602,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.NobleGas,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Helium",
                    CountryOfDiscovery = CountryOfDiscovery.UkFrance
                },
                new Element
                {
                    Group = 1,
                    Period = 2,
                    Name = "Lithium",
                    AtomicNumber = 3,
                    ChemicalSymbol = "Li",
                    RelativeAtomicMass = 6.941,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkaliMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Lithium",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 2,
                    Period = 2,
                    Name = "Berylium",
                    AtomicNumber = 4,
                    ChemicalSymbol = "Be",
                    RelativeAtomicMass = 9.012182,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkalineEarthMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Berylium",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 13,
                    Period = 2,
                    Name = "Boron",
                    AtomicNumber = 5,
                    ChemicalSymbol = "B",
                    RelativeAtomicMass = 10.811,
                    MassUncertainty = 7,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.Metalloid,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Boron",
                    CountryOfDiscovery = CountryOfDiscovery.UkFrance
                },
                new Element
                {
                    Group = 14,
                    Period = 2,
                    Name = "Carbon",
                    AtomicNumber = 6,
                    ChemicalSymbol = "C",
                    RelativeAtomicMass = 12.0107,
                    MassUncertainty = 8,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PolyatomicNonmetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Carbon",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 15,
                    Period = 2,
                    Name = "Nitrogen",
                    AtomicNumber = 7,
                    ChemicalSymbol = "N",
                    RelativeAtomicMass = 14.0067,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.DiatomicNonmetal,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Nitrogen",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 16,
                    Period = 2,
                    Name = "Oxygen",
                    AtomicNumber = 8,
                    ChemicalSymbol = "O",
                    RelativeAtomicMass = 15.9994,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.DiatomicNonmetal,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Oxygen",
                    CountryOfDiscovery = CountryOfDiscovery.UkSwedenFrance
                },
                new Element
                {
                    Group = 17,
                    Period = 2,
                    Name = "Fluorine",
                    AtomicNumber = 9,
                    ChemicalSymbol = "F",
                    RelativeAtomicMass = 18.9984032,
                    MassUncertainty = 5,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.DiatomicNonmetal,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Fluorine",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 18,
                    Period = 2,
                    Name = "Neon",
                    AtomicNumber = 10,
                    ChemicalSymbol = "Ne",
                    RelativeAtomicMass = 20.1797,
                    MassUncertainty = 6,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.NobleGas,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Neon",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 1,
                    Period = 3,
                    Name = "Sodium",
                    AtomicNumber = 11,
                    ChemicalSymbol = "Na",
                    RelativeAtomicMass = 22.98976928,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkaliMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Sodium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 2,
                    Period = 3,
                    Name = "Magnesium",
                    AtomicNumber = 12,
                    ChemicalSymbol = "Mg",
                    RelativeAtomicMass = "24.3050",
                    MassUncertainty = 6,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkalineEarthMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Magnesium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 13,
                    Period = 3,
                    Name = "Aluminium",
                    AtomicNumber = 13,
                    ChemicalSymbol = "Al",
                    RelativeAtomicMass = 26.9815386,
                    MassUncertainty = 8,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Aluminium",
                    CountryOfDiscovery = CountryOfDiscovery.Denmark
                },
                new Element
                {
                    Group = 14,
                    Period = 3,
                    Name = "Silicon",
                    AtomicNumber = 14,
                    ChemicalSymbol = "Si",
                    RelativeAtomicMass = 28.0855,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.Metalloid,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Silicon",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 15,
                    Period = 3,
                    Name = "Phosphorus",
                    AtomicNumber = 15,
                    ChemicalSymbol = "P",
                    RelativeAtomicMass = 30.973762,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PolyatomicNonmetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Phosphorus",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 16,
                    Period = 3,
                    Name = "Sulfur",
                    AtomicNumber = 16,
                    ChemicalSymbol = "S",
                    RelativeAtomicMass = 32.065,
                    MassUncertainty = 5,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PolyatomicNonmetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Sulfur",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 17,
                    Period = 3,
                    Name = "Chlorine",
                    AtomicNumber = 17,
                    ChemicalSymbol = "Cl",
                    RelativeAtomicMass = 35.453,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.DiatomicNonmetal,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Chlorine",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 18,
                    Period = 3,
                    Name = "Argon",
                    AtomicNumber = 18,
                    ChemicalSymbol = "Ar",
                    RelativeAtomicMass = 39.948,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.NobleGas,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Arhon",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 1,
                    Period = 4,
                    Name = "Potassium",
                    AtomicNumber = 19,
                    ChemicalSymbol = "K",
                    RelativeAtomicMass = 39.0983,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkaliMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Potassium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 2,
                    Period = 4,
                    Name = "Calcium",
                    AtomicNumber = 20,
                    ChemicalSymbol = "Ca",
                    RelativeAtomicMass = 40.078,
                    MassUncertainty = 4,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkalineEarthMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Calcium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 3,
                    Period = 4,
                    Name = "Scandium",
                    AtomicNumber = 21,
                    ChemicalSymbol = "Sc",
                    RelativeAtomicMass = 44.955912,
                    MassUncertainty = 6,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Scandium",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 4,
                    Period = 4,
                    Name = "Titanium",
                    AtomicNumber = 22,
                    ChemicalSymbol = "Ti",
                    RelativeAtomicMass = 47.867,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Titanium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 5,
                    Period = 4,
                    Name = "Vanadium",
                    AtomicNumber = 23,
                    ChemicalSymbol = "V",
                    RelativeAtomicMass = 50.9415,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Vanadium",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 6,
                    Period = 4,
                    Name = "Chromium",
                    AtomicNumber = 24,
                    ChemicalSymbol = "Cr",
                    RelativeAtomicMass = 51.9961,
                    MassUncertainty = 6,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Chromium",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 7,
                    Period = 4,
                    Name = "Manganese",
                    AtomicNumber = 25,
                    ChemicalSymbol = "Mn",
                    RelativeAtomicMass = 54.938045,
                    MassUncertainty = 5,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Manganese",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 8,
                    Period = 4,
                    Name = "Iron",
                    AtomicNumber = 26,
                    ChemicalSymbol = "Fe",
                    RelativeAtomicMass = 55.845,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Iron",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 9,
                    Period = 4,
                    Name = "Cobalt",
                    AtomicNumber = 27,
                    ChemicalSymbol = "Co",
                    RelativeAtomicMass = 58.933195,
                    MassUncertainty = 4,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Cobalt",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 10,
                    Period = 4,
                    Name = "Nickel",
                    AtomicNumber = 28,
                    ChemicalSymbol = "Ni",
                    RelativeAtomicMass = 58.6934,
                    MassUncertainty = 4,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Nickel",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 11,
                    Period = 4,
                    Name = "Copper",
                    AtomicNumber = 29,
                    ChemicalSymbol = "Cu",
                    RelativeAtomicMass = 63.546,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Copper",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 12,
                    Period = 4,
                    Name = "Zinc",
                    AtomicNumber = 30,
                    ChemicalSymbol = "Zn",
                    RelativeAtomicMass = 65.38,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Zinc",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncientsGermany
                },
                new Element
                {
                    Group = 13,
                    Period = 4,
                    Name = "Galium",
                    AtomicNumber = 31,
                    ChemicalSymbol = "Ga",
                    RelativeAtomicMass = 69.723,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Galium",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 14,
                    Period = 4,
                    Name = "Germanium",
                    AtomicNumber = 32,
                    ChemicalSymbol = "Ge",
                    RelativeAtomicMass = 72.63,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.Metalloid,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Germanium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 15,
                    Period = 4,
                    Name = "Arsenic",
                    AtomicNumber = 33,
                    ChemicalSymbol = "Ar",
                    RelativeAtomicMass = "74.92160",
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.Metalloid,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Arsenic",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 16,
                    Period = 4,
                    Name = "Selenium",
                    AtomicNumber = 34,
                    ChemicalSymbol = "Se",
                    RelativeAtomicMass = 78.96,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PolyatomicNonmetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Selenium",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 17,
                    Period = 4,
                    Name = "Bromine",
                    AtomicNumber = 35,
                    ChemicalSymbol = "Br",
                    RelativeAtomicMass = 79.904,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.DiatomicNonmetal,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Bromine",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 18,
                    Period = 4,
                    Name = "Krypton",
                    AtomicNumber = 36,
                    ChemicalSymbol = "Kr",
                    RelativeAtomicMass = 83.798,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.NobleGas,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Krypton",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 1,
                    Period = 5,
                    Name = "Rubidium",
                    AtomicNumber = 37,
                    ChemicalSymbol = "Rb",
                    RelativeAtomicMass = 85.4678,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkaliMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Rubidium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 2,
                    Period = 5,
                    Name = "Strontium",
                    AtomicNumber = 38,
                    ChemicalSymbol = "Sr",
                    RelativeAtomicMass = 87.62,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkalineEarthMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Strontium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 3,
                    Period = 5,
                    Name = "Yttrium",
                    AtomicNumber = 39,
                    ChemicalSymbol = "Y",
                    RelativeAtomicMass = 88.90585,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Yttrium",
                    CountryOfDiscovery = CountryOfDiscovery.Finland
                },
                new Element
                {
                    Group = 4,
                    Period = 5,
                    Name = "Zirconium",
                    AtomicNumber = 40,
                    ChemicalSymbol = "Zr",
                    RelativeAtomicMass = 91.224,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Zirconium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 5,
                    Period = 5,
                    Name = "Niobium",
                    AtomicNumber = 41,
                    ChemicalSymbol = "Nb",
                    RelativeAtomicMass = 92.90638,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Niobium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 6,
                    Period = 5,
                    Name = "Molybdenum",
                    AtomicNumber = 42,
                    ChemicalSymbol = "Mo",
                    RelativeAtomicMass = 95.96,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Molybdenum",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 7,
                    Period = 5,
                    Name = "Technetium",
                    AtomicNumber = 43,
                    ChemicalSymbol = "Tc",
                    RelativeAtomicMass = 98,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.FromDecay,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Technetium",
                    CountryOfDiscovery = CountryOfDiscovery.Italy
                },
                new Element
                {
                    Group = 8,
                    Period = 5,
                    Name = "Ruthenium",
                    AtomicNumber = 44,
                    ChemicalSymbol = "Ru",
                    RelativeAtomicMass = 101.07,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Ruthenium",
                    CountryOfDiscovery = CountryOfDiscovery.Russia
                },
                new Element
                {
                    Group = 9,
                    Period = 5,
                    Name = "Rhodium",
                    AtomicNumber = 45,
                    ChemicalSymbol = "Rh",
                    RelativeAtomicMass = "102.90550",
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Rhodium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 10,
                    Period = 5,
                    Name = "Palladium",
                    AtomicNumber = 46,
                    ChemicalSymbol = "Pd",
                    RelativeAtomicMass = 106.42,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Palladium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 11,
                    Period = 5,
                    Name = "Silver",
                    AtomicNumber = 47,
                    ChemicalSymbol = "Ag",
                    RelativeAtomicMass = 107.8682,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Silver",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 12,
                    Period = 5,
                    Name = "Cadmium",
                    AtomicNumber = 48,
                    ChemicalSymbol = "Cd",
                    RelativeAtomicMass = 112.411,
                    MassUncertainty = 8,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Cadmium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 13,
                    Period = 5,
                    Name = "Indium",
                    AtomicNumber = 49,
                    ChemicalSymbol = "In",
                    RelativeAtomicMass = 114.818,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Indium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 14,
                    Period = 5,
                    Name = "Tin",
                    AtomicNumber = 50,
                    ChemicalSymbol = "Sn",
                    RelativeAtomicMass = "118.710",
                    MassUncertainty = 7,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Tin",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 15,
                    Period = 5,
                    Name = "Antimony",
                    AtomicNumber = 51,
                    ChemicalSymbol = "Sb",
                    RelativeAtomicMass = "121.760",
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.Metalloid,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Antimony",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 16,
                    Period = 5,
                    Name = "Tellurium",
                    AtomicNumber = 52,
                    ChemicalSymbol = "Te",
                    RelativeAtomicMass = "127.60",
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.Metalloid,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Tellurium",
                    CountryOfDiscovery = CountryOfDiscovery.Romania
                },
                new Element
                {
                    Group = 17,
                    Period = 5,
                    Name = "Iodine",
                    AtomicNumber = 53,
                    ChemicalSymbol = "I",
                    RelativeAtomicMass = 126.90447,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.DiatomicNonmetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Iodine",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 18,
                    Period = 5,
                    Name = "Xenon",
                    AtomicNumber = 54,
                    ChemicalSymbol = "Xe",
                    RelativeAtomicMass = 131.293,
                    MassUncertainty = 6,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.NobleGas,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Xenon",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 1,
                    Period = 6,
                    Name = "Caesium",
                    AtomicNumber = 55,
                    ChemicalSymbol = "Cs",
                    RelativeAtomicMass = 132.9054519,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkaliMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Caesium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 2,
                    Period = 6,
                    Name = "Barium",
                    AtomicNumber = 56,
                    ChemicalSymbol = "Ba",
                    RelativeAtomicMass = 137.327,
                    MassUncertainty = 7,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.AlkalineEarthMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Barium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 3,
                    Period = 6,
                    Name = "Lanthanides",
                    AtomicNumber = "57-71",
                    ChemicalSymbol = "*",
                    ChemicalProperty = ChemicalProperty.Lanthanide,
                    Url = "http://en.wikipedia.org/wiki/Lanthanides"
                },
                new Element
                {
                    Group = 4,
                    Period = 6,
                    Name = "Hafnium",
                    AtomicNumber = 72,
                    ChemicalSymbol = "Hf",
                    RelativeAtomicMass = 178.49,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Hafnium",
                    CountryOfDiscovery = CountryOfDiscovery.Switzerland
                },
                new Element
                {
                    Group = 5,
                    Period = 6,
                    Name = "Tantalum",
                    AtomicNumber = 73,
                    ChemicalSymbol = "Ta",
                    RelativeAtomicMass = 180.94788,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Tantalum",
                    CountryOfDiscovery = CountryOfDiscovery.Sweden
                },
                new Element
                {
                    Group = 6,
                    Period = 6,
                    Name = "Tungsten",
                    AtomicNumber = 74,
                    ChemicalSymbol = "W",
                    RelativeAtomicMass = 183.84,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Tungsten",
                    CountryOfDiscovery = CountryOfDiscovery.Spain
                },
                new Element
                {
                    Group = 7,
                    Period = 6,
                    Name = "Rhenium",
                    AtomicNumber = 75,
                    ChemicalSymbol = "Re",
                    RelativeAtomicMass = 186.207,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Rhenium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 8,
                    Period = 6,
                    Name = "Osmium",
                    AtomicNumber = 76,
                    ChemicalSymbol = "Os",
                    RelativeAtomicMass = 190.23,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Osmium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 9,
                    Period = 6,
                    Name = "Iridium",
                    AtomicNumber = 77,
                    ChemicalSymbol = "Ir",
                    RelativeAtomicMass = 192.217,
                    MassUncertainty = 3,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Iridium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 10,
                    Period = 6,
                    Name = "Platinum",
                    AtomicNumber = 78,
                    ChemicalSymbol = "Pt",
                    RelativeAtomicMass = 195.084,
                    MassUncertainty = 9,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Platinum",
                    CountryOfDiscovery = CountryOfDiscovery.Spain
                },
                new Element
                {
                    Group = 11,
                    Period = 6,
                    Name = "Gold",
                    AtomicNumber = 79,
                    ChemicalSymbol = "Au",
                    RelativeAtomicMass = 196.966569,
                    MassUncertainty = 4,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Gold",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 12,
                    Period = 6,
                    Name = "Mercury",
                    AtomicNumber = 80,
                    ChemicalSymbol = "Hg",
                    RelativeAtomicMass = 200.59,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Mercury",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 13,
                    Period = 6,
                    Name = "Thallium",
                    AtomicNumber = 81,
                    ChemicalSymbol = "Tl",
                    RelativeAtomicMass = 204.3833,
                    MassUncertainty = 2,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Thallium",
                    CountryOfDiscovery = CountryOfDiscovery.Uk
                },
                new Element
                {
                    Group = 14,
                    Period = 6,
                    Name = "Lead",
                    AtomicNumber = 82,
                    ChemicalSymbol = "Pb",
                    RelativeAtomicMass = 207.2,
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Lead",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 15,
                    Period = 6,
                    Name = "Bismuth",
                    AtomicNumber = 83,
                    ChemicalSymbol = "Bi",
                    RelativeAtomicMass = "208.98040",
                    MassUncertainty = 1,
                    NaturalOccurrence = NaturalOccurrence.Primordial,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Bismuth",
                    CountryOfDiscovery = CountryOfDiscovery.KnownToAncients
                },
                new Element
                {
                    Group = 16,
                    Period = 6,
                    Name = "Polonium",
                    AtomicNumber = 84,
                    ChemicalSymbol = "Po",
                    RelativeAtomicMass = 209,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.FromDecay,
                    ChemicalProperty = ChemicalProperty.PoorMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Polonium",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 17,
                    Period = 6,
                    Name = "Astatine",
                    AtomicNumber = 85,
                    ChemicalSymbol = "At",
                    RelativeAtomicMass = 210,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.FromDecay,
                    ChemicalProperty = ChemicalProperty.Metalloid,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Astatine",
                    CountryOfDiscovery = CountryOfDiscovery.Usa
                },
                new Element
                {
                    Group = 18,
                    Period = 6,
                    Name = "Radon",
                    AtomicNumber = 86,
                    ChemicalSymbol = "Rn",
                    RelativeAtomicMass = 222,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.FromDecay,
                    ChemicalProperty = ChemicalProperty.NobleGas,
                    State = State.Gas,
                    Url = "http://en.wikipedia.org/wiki/Radon",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 1,
                    Period = 7,
                    Name = "Francium",
                    AtomicNumber = 87,
                    ChemicalSymbol = "Fr",
                    RelativeAtomicMass = 223,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.FromDecay,
                    ChemicalProperty = ChemicalProperty.AlkaliMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Francium",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 2,
                    Period = 7,
                    Name = "Radium",
                    AtomicNumber = 88,
                    ChemicalSymbol = "Ra",
                    RelativeAtomicMass = 226,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.FromDecay,
                    ChemicalProperty = ChemicalProperty.AlkalineEarthMetal,
                    State = State.Solid,
                    Url = "http://en.wikipedia.org/wiki/Radium",
                    CountryOfDiscovery = CountryOfDiscovery.France
                },
                new Element
                {
                    Group = 3,
                    Period = 7,
                    Name = "Actinides",
                    AtomicNumber = "89-103",
                    ChemicalSymbol = "**",
                    ChemicalProperty = ChemicalProperty.Actinide,
                    Url = "http://en.wikipedia.org/wiki/Actinides"
                },
                new Element
                {
                    Group = 4,
                    Period = 7,
                    Name = "Rutherfordium",
                    AtomicNumber = 104,
                    ChemicalSymbol = "Rf",
                    RelativeAtomicMass = 267,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Rutherfordium",
                    CountryOfDiscovery = CountryOfDiscovery.UsaRussia
                },
                new Element
                {
                    Group = 5,
                    Period = 7,
                    Name = "Dubnium",
                    AtomicNumber = 105,
                    ChemicalSymbol = "Db",
                    RelativeAtomicMass = 268,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Dubnium",
                    CountryOfDiscovery = CountryOfDiscovery.Usa
                },
                new Element
                {
                    Group = 6,
                    Period = 7,
                    Name = "Seaborgium",
                    AtomicNumber = 106,
                    ChemicalSymbol = "Sg",
                    RelativeAtomicMass = 269,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Seaborgium",
                    CountryOfDiscovery = CountryOfDiscovery.UsaRussia
                },
                new Element
                {
                    Group = 7,
                    Period = 7,
                    Name = "Bohrium",
                    AtomicNumber = 107,
                    ChemicalSymbol = "Bh",
                    RelativeAtomicMass = 270,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Bohrium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 8,
                    Period = 7,
                    Name = "Hassium",
                    AtomicNumber = 108,
                    ChemicalSymbol = "Hs",
                    RelativeAtomicMass = 269,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Hassium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 9,
                    Period = 7,
                    Name = "Meitnerium",
                    AtomicNumber = 109,
                    ChemicalSymbol = "Mt",
                    RelativeAtomicMass = 278,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Meitnerium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 10,
                    Period = 7,
                    Name = "Darmstadtium",
                    AtomicNumber = 110,
                    ChemicalSymbol = "Ds",
                    RelativeAtomicMass = 281,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Darmstadtium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 11,
                    Period = 7,
                    Name = "Roentgenium",
                    AtomicNumber = 111,
                    ChemicalSymbol = "Rg",
                    RelativeAtomicMass = 281,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Roentgenium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 12,
                    Period = 7,
                    Name = "Copernicium",
                    AtomicNumber = 112,
                    ChemicalSymbol = "Cn",
                    RelativeAtomicMass = 285,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.TransitionMetal,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Copernicium",
                    CountryOfDiscovery = CountryOfDiscovery.Germany
                },
                new Element
                {
                    Group = 13,
                    Period = 7,
                    Name = "Ununtrium",
                    AtomicNumber = 113,
                    ChemicalSymbol = "Uut",
                    RelativeAtomicMass = 286,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Ununtrium",
                    CountryOfDiscovery = CountryOfDiscovery.Undiscovered
                },
                new Element
                {
                    Group = 14,
                    Period = 7,
                    Name = "Flerovium",
                    AtomicNumber = 114,
                    ChemicalSymbol = "Fl",
                    RelativeAtomicMass = 289,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Flerovium",
                    CountryOfDiscovery = CountryOfDiscovery.UsaRussia
                },
                new Element
                {
                    Group = 15,
                    Period = 7,
                    Name = "Ununpentium",
                    AtomicNumber = 115,
                    ChemicalSymbol = "Uup",
                    RelativeAtomicMass = 288,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Ununpentium",
                    CountryOfDiscovery = CountryOfDiscovery.Undiscovered
                },
                new Element
                {
                    Group = 16,
                    Period = 7,
                    Name = "Livermorium",
                    AtomicNumber = 116,
                    ChemicalSymbol = "Lv",
                    RelativeAtomicMass = 293,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Livermorium",
                    CountryOfDiscovery = CountryOfDiscovery.UsaRussia
                },
                new Element
                {
                    Group = 17,
                    Period = 7,
                    Name = "Ununseptium",
                    AtomicNumber = 117,
                    ChemicalSymbol = "Uus",
                    RelativeAtomicMass = 294,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Ununseptium",
                    CountryOfDiscovery = CountryOfDiscovery.Undiscovered
                },
                new Element
                {
                    Group = 18,
                    Period = 7,
                    Name = "Ununoctium",
                    AtomicNumber = 118,
                    ChemicalSymbol = "Uuo",
                    RelativeAtomicMass = 294,
                    MassUncertainty = 0,
                    NaturalOccurrence = NaturalOccurrence.Synthetic,
                    ChemicalProperty = ChemicalProperty.Unknown,
                    State = State.Unknown,
                    Url = "http://en.wikipedia.org/wiki/Ununoctium",
                    CountryOfDiscovery = CountryOfDiscovery.Undiscovered
                }
            };
        }
    }
}