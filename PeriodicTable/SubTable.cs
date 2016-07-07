namespace PeriodicTable
{
    using PeriodicTable.Report.Rdl;

    public class SubTable
    {
        public static ReportItem Create(string dataSetName)
        {
            return new Tablix(
                CreateTablixCorner(),
                CreateTablixColumnHierarchy(),
                CreateTablixRowHierarchy(),
                CreateTablixBody(dataSetName),
                dataSetName)
                       {
                           Top = new Inch(1.4), Left = new Inch(1.5)
                       };
        }

        private static TablixCorner CreateTablixCorner()
        {
            return
                new TablixCorner(
                    new TablixCornerRows(
                        new TablixCornerRow(
                            new TablixCornerCell(
                                new CellContents(new Textbox(new Paragraph(new TextRuns(new TextRun()))))))));
        }

        private static TablixColumnHierarchy CreateTablixColumnHierarchy()
        {
            var group = new Group(new GroupExpressions(new GroupExpression(CreateColumnGroupExpression())));
            
            var sortExpression =
                new SortExpression(new Value("=" + Expression.FieldsValue(ElementProperty.AtomicNumber)));
            var sortExpressions = new SortExpressions(sortExpression);
            
            var header = new TablixHeader(
                new Inch(0.3),
                new CellContents(new Textbox(new Paragraph(new TextRuns(new TextRun())))));
            
            return new TablixColumnHierarchy(new TablixMembers(new TablixMember(group, sortExpressions, header)));
        }

        private static TablixRowHierarchy CreateTablixRowHierarchy()
        {
            var group =
                new Group(
                    new GroupExpressions(
                        new GroupExpression("=" + Expression.FieldsValue(ElementProperty.ChemicalProperty))));

            var sortExpressions =
                new SortExpressions(
                    new SortExpression(new Value("=" + Expression.FieldsValue(ElementProperty.ChemicalProperty))));

            var textRun = new TextRun { Value = CreateRowHierarchyTextExpression(), FontWeight = FontWeight.Bold };
            var paragraph = new Paragraph(new TextRuns(textRun)) { TextAlign = TextAlign.Right };
            var textbox = new Textbox(paragraph)
                              {
                                  TextboxStyle = new TextboxStyle { VerticalAlign = VerticalAlign.Middle }
                              };
            var header = new TablixHeader(new Inch(1.3), new CellContents(textbox));
            
            return new TablixRowHierarchy(new TablixMembers(new TablixMember(group, sortExpressions, header)));
        }

        private static TablixBody CreateTablixBody(string dataSetName)
        {
            var rectangle = new Rectangle();
            rectangle.AddReportItem(ElementCell.Create(dataSetName));
            var tablixColumns = new TablixColumns(new TablixColumn(new Width(new Inch(1.05))));
            var tablixCells = new TablixCells(new TablixCell(new CellContents(rectangle)));
            var tablixRows = new TablixRows(new TablixRow(new Inch(0.85), tablixCells));
            return new TablixBody(tablixColumns, tablixRows);
        }

        private static string CreateColumnGroupExpression()
        {
            const int LanthanumAtomicNumber = 57;
            const int ActiniumAtomicNumber = 89;
            return "=IIf("
                + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "=" + (int)ChemicalProperty.Lanthanide + ","
                + Expression.FieldsValue(ElementProperty.AtomicNumber) + "-" + LanthanumAtomicNumber + ","
                + Expression.FieldsValue(ElementProperty.AtomicNumber) + "-" + ActiniumAtomicNumber + ")";
        }

        private static string CreateRowHierarchyTextExpression()
        {
            var result = "=IIf(" + Expression.FieldsValue(ElementProperty.ChemicalProperty) + "="
                         + (int)ChemicalProperty.Lanthanide + ", '* Lanthanides', '** Actinides')";
            return result.ReplaceSingleQuoteWithDoubleQuote();
        }
    }
}
