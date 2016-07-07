using DynamicRdlc.Rdl;

namespace PeriodicTable
{
    public class ElementCell
    {
        public static ReportItem Create(string dataSetName)
        {
            return new Tablix(CreateTablixColumnHierarchy(), CreateTablixRowHierarchy(), CreateTablixBody(), dataSetName)
                       {
                           Top = new Inch(0.025),
                           Left = new Inch(0.025),
                           Style = CreateTablixStyle()
                       };
        }

        private static TablixColumnHierarchy CreateTablixColumnHierarchy()
        {
            return new TablixColumnHierarchy(new TablixMembers(new TablixMember()));
        }

        private static TablixRowHierarchy CreateTablixRowHierarchy()
        {
            var tablixRowMembers = new TablixMembers();
            tablixRowMembers.Add(new TablixMember());
            tablixRowMembers.Add(new TablixMember());
            tablixRowMembers.Add(new TablixMember());
            tablixRowMembers.Add(new TablixMember());
            return new TablixRowHierarchy(tablixRowMembers);
        }

        private static TablixBody CreateTablixBody()
        {
            var tablixRows = new TablixRows();
            tablixRows.Add(CreateFirstTablixRow());
            tablixRows.Add(CreateSecondTablixRow());
            tablixRows.Add(CreateThirdTablixRow());
            tablixRows.Add(CreateFourthTablixRow());
            var tablixColumns = new TablixColumns(new TablixColumn(new Width(new Inch(1))));
            return new TablixBody(tablixColumns, tablixRows);
        }

        private static TablixRow CreateFirstTablixRow()
        {
            var textRun = new TextRun
                              {
                                  Value = "=" + Expression.FieldsValue(ElementProperty.AtomicNumber),
                                  FontSize = new Point(12)
                              };
            var paragraph = new Paragraph(new TextRuns(textRun)) { TextAlign = TextAlign.Center };
            var textbox = new Textbox(paragraph) { TextboxStyle = new TextboxStyle() };
            var tablixCells = new TablixCells(new TablixCell(new CellContents(textbox)));
            return new TablixRow(new Inch(0.2), tablixCells);
        }

        private static TablixRow CreateSecondTablixRow()
        {
            var textRun = new TextRun
                                {
                                    Value = "=" + Expression.FieldsValue(ElementProperty.ChemicalSymbol),
                                    FontSize = new Point(16),
                                    FontWeight = FontWeight.Bold,
                                    Color = CreateTextColorExpressionForChemicalSymbol()
                                };
            var paragraph = new Paragraph(new TextRuns(textRun)) { TextAlign = TextAlign.Center };
            var textbox = new Textbox(paragraph) { TextboxStyle = new TextboxStyle() };
            var tablixCells = new TablixCells(new TablixCell(new CellContents(textbox)));
            return new TablixRow(new Inch(0.28), tablixCells);
        }

        private static TablixRow CreateThirdTablixRow()
        {
            var textRun = new TextRun { Value = CreateHyperLinkExpression(), MarkupType = MarkupType.HTML };
            var paragraph = new Paragraph(new TextRuns(textRun)) { TextAlign = TextAlign.Center };
            var textbox = new Textbox(paragraph) { TextboxStyle = new TextboxStyle() };
            var tablixCells = new TablixCells(new TablixCell(new CellContents(textbox)));
            return new TablixRow(new Inch(0.18), tablixCells);
        }

        private static TablixRow CreateFourthTablixRow()
        {
            var textRun = new TextRun { Value = CreateRelativeAtomicMassExpression() };
            var paragraph = new Paragraph(new TextRuns(textRun)) { TextAlign = TextAlign.Right };
            var textbox = new Textbox(paragraph) { TextboxStyle = new TextboxStyle() };
            var tablixCells = new TablixCells(new TablixCell(new CellContents(textbox)));
            return new TablixRow(new Inch(0.15), tablixCells);
        }

        private static Style CreateTablixStyle()
        {
            var border = new Border
            {
                Color = RdlColor.Maroon.ToString(),
                Style = CreateTablixBorderStyleExpression(),
                Width = new Point(2)
            };
            var backgroundImage = new BackgroundImage(
                Source.Embedded,
                BackgroundRepeat.Clip,
                CreateTablixBackgroundImageExpression());
            return new Style
            {
                Border = border,
                BackgroundImage = backgroundImage,
                BackgroundColor = CreateTablixBackgroundColorExpression()
            };
        }

        private static string CreateTextColorExpressionForChemicalSymbol()
        {
            var result = "=Switch(Not IsNumeric("
                + Expression.FieldsValue(ElementProperty.AtomicNumber) + "), '" + RdlColor.Black + "',"
                + Expression.FieldsValue(ElementProperty.State) + "=" + (int)State.Unknown + ", '" + RdlColor.Gray + "',"
                + Expression.FieldsValue(ElementProperty.State) + "=" + (int)State.Solid + ", '" + RdlColor.DarkBlue + "',"
                + Expression.FieldsValue(ElementProperty.State) + "=" + (int)State.Liquid + ", '" + RdlColor.Aqua + "',"
                + Expression.FieldsValue(ElementProperty.State) + "=" + (int)State.Gas + ", '" + RdlColor.Red + "')";
            return result.ReplaceSingleQuoteWithDoubleQuote();
        }

        private static string CreateHyperLinkExpression()
        {
            var result =
                "='<a href=''' & IIf(IsNothing(" + Expression.FieldsValue(ElementProperty.Url) + "),"
                + "'mailTo:me.com',"
                + Expression.FieldsValue(ElementProperty.Url) + ")"
                + " & '''>' & " + Expression.FieldsValue(ElementProperty.Name) + " & '</a>'";
            return result.ReplaceSingleQuoteWithDoubleQuote();
        }

        private static string CreateRelativeAtomicMassExpression()
        {
            var result =
                "=IIf(" + Expression.FieldsValue(ElementProperty.MassUncertainty) + " <> 0,"
                + Expression.FieldsValue(ElementProperty.RelativeAtomicMass) + " & '(' & "
                + Expression.FieldsValue(ElementProperty.MassUncertainty) + " & ')',"
                + "IIf(IsNumeric(" + Expression.FieldsValue(ElementProperty.AtomicNumber) + "),"
                + "'[' &" + Expression.FieldsValue(ElementProperty.RelativeAtomicMass) + " & ']',''))";
            return result.ReplaceSingleQuoteWithDoubleQuote();
        }

        private static string CreateTablixBorderStyleExpression()
        {
            var result = "=Switch(Not IsNumeric("
                + Expression.FieldsValue(ElementProperty.AtomicNumber) + "), '" + BorderStyle.None + "',"
                + Expression.FieldsValue(ElementProperty.NaturalOccurrence) + "=" + (int)NaturalOccurrence.Primordial + ", '" + BorderStyle.Solid + "',"
                + Expression.FieldsValue(ElementProperty.NaturalOccurrence) + "=" + (int)NaturalOccurrence.FromDecay + ", '" + BorderStyle.Dashed + "',"
                + Expression.FieldsValue(ElementProperty.NaturalOccurrence) + "=" + (int)NaturalOccurrence.Synthetic + ", '" + BorderStyle.Dotted + "')";
            return result.ReplaceSingleQuoteWithDoubleQuote();
        }

        private static string CreateTablixBackgroundImageExpression()
        {
            var result = "=Switch(IsNothing("
                + Expression.FieldsValue(ElementProperty.AtomicNumber) + "), '" + CountryOfDiscovery.Undiscovered + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.KnownToAncients + ", '" + CountryOfDiscovery.KnownToAncients + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.KnownToAncientsGermany + ", '" + CountryOfDiscovery.KnownToAncientsGermany + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Austria + ", '" + CountryOfDiscovery.Austria + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Denmark + ", '" + CountryOfDiscovery.Denmark + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Finland + ", '" + CountryOfDiscovery.Finland + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.France + ", '" + CountryOfDiscovery.France + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Germany + ", '" + CountryOfDiscovery.Germany + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.GermanySweden + ", '" + CountryOfDiscovery.GermanySweden + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Italy + ", '" + CountryOfDiscovery.Italy + "', "
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Romania + ", '" + CountryOfDiscovery.Romania + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Russia + ", '" + CountryOfDiscovery.Russia + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Spain + ", '" + CountryOfDiscovery.Spain + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Sweden + ", '" + CountryOfDiscovery.Sweden + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Switzerland + ", '" + CountryOfDiscovery.Switzerland + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Uk + ", '" + CountryOfDiscovery.Uk + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.UkFrance + ", '" + CountryOfDiscovery.UkFrance + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.UkGermany + ", '" + CountryOfDiscovery.UkGermany + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.UkSwedenFrance + ", '" + CountryOfDiscovery.UkSwedenFrance + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.Usa + ", '" + CountryOfDiscovery.Usa + "',"
                + Expression.FieldsValue(ElementProperty.CountryOfDiscovery) + "=" + (int)CountryOfDiscovery.UsaRussia + ", '" + CountryOfDiscovery.UsaRussia + "')";
            return result.ReplaceSingleQuoteWithDoubleQuote();
        }

        private static string CreateTablixBackgroundColorExpression()
        {
            var result = "=Switch(IsNothing("
                + Expression.FieldsValue(ElementProperty.AtomicNumber) + ") OrElse Not IsNumeric("
                + Expression.FieldsValue(ElementProperty.AtomicNumber) + "), '" + RdlColor.White + "',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.Unknown + ", '#e8e8e8',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.AlkaliMetal + ", '#ff6666',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.AlkalineEarthMetal + ", '#ffdead',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.Lanthanide + ", '#ffbfff',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.Actinide + ", '#ff99cc',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.TransitionMetal + ", '#ffc0c0',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.PoorMetal + ", '#cccccc',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.Metalloid + ", '#cccc99',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.PolyatomicNonmetal + ", '#a1ffc3',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.DiatomicNonmetal + ", '#e7ff8f',"
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.NobleGas + ", '#c0ffff')";
            return result.ReplaceSingleQuoteWithDoubleQuote();
        }
    }
}
