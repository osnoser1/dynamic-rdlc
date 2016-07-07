namespace PeriodicTable
{
    using Microsoft.Reporting.WinForms;

    using PeriodicTable.Properties;
    using PeriodicTable.Report.Rdl;

    public class PeriodicTableReportGenerator : ReportGenerator
    {
        public PeriodicTableReportGenerator(LocalReport localReport)
            : base(localReport)
        {
        }

        public override void Run()
        {
            var dataSetForMainTable = CreateDataSet();
            var mainTable = MainTable.Create(dataSetForMainTable.Name);
            var dataSetForSubTable = CreateDataSet();
            var subTable = SubTable.Create(dataSetForSubTable.Name);
            var body = new Body();
            body.AddReportItem(mainTable);
            body.AddReportItem(subTable);
            this.Report.AddReportSection(new ReportSection(body));
            
            this.Report.AddDataSet(dataSetForMainTable);
            this.Report.AddDataSet(dataSetForSubTable);
            this.DataSources.Add(new ReportDataSource(dataSetForMainTable.Name, MainTableDataSource.Create()));
            this.DataSources.Add(new ReportDataSource(dataSetForSubTable.Name, SubTableDataSource.Create()));

            this.CreateEmbeddedImages();

            base.Run();
        }

        private static DataSet CreateDataSet()
        {
            var dataSet = new DataSet();
            dataSet.AddField(ElementProperty.Group);
            dataSet.AddField(ElementProperty.Period);
            dataSet.AddField(ElementProperty.Name);
            dataSet.AddField(ElementProperty.AtomicNumber);
            dataSet.AddField(ElementProperty.ChemicalSymbol);
            dataSet.AddField(ElementProperty.RelativeAtomicMass);
            dataSet.AddField(ElementProperty.MassUncertainty);
            dataSet.AddField(ElementProperty.ChemicalProperty);
            dataSet.AddField(ElementProperty.NaturalOccurrence);
            dataSet.AddField(ElementProperty.CountryOfDiscovery);
            dataSet.AddField(ElementProperty.State);
            dataSet.AddField(ElementProperty.Url);
            return dataSet;
        }

        private void CreateEmbeddedImages()
        {
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.NoBackground, CountryOfDiscovery.Undiscovered.ToString()));
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Aristotle, CountryOfDiscovery.KnownToAncients.ToString()));
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Aristotle_Germany, CountryOfDiscovery.KnownToAncientsGermany.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Austria, CountryOfDiscovery.Austria.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Denmark, CountryOfDiscovery.Denmark.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Finland, CountryOfDiscovery.Finland.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.France, CountryOfDiscovery.France.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Germany, CountryOfDiscovery.Germany.ToString()));
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Germany_Sweden, CountryOfDiscovery.GermanySweden.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Italy, CountryOfDiscovery.Italy.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Romania, CountryOfDiscovery.Romania.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Russia, CountryOfDiscovery.Russia.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Spain, CountryOfDiscovery.Spain.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.Sweden, CountryOfDiscovery.Sweden.ToString()));
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Switzerland, CountryOfDiscovery.Switzerland.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.UK, CountryOfDiscovery.Uk.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.UK_France, CountryOfDiscovery.UkFrance.ToString()));
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.UK_Germany, CountryOfDiscovery.UkGermany.ToString()));
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.UK_Sweden_France, CountryOfDiscovery.UkSwedenFrance.ToString()));
            this.Report.AddEmbeddedImage(new EmbeddedImage(Resources.USA, CountryOfDiscovery.Usa.ToString()));
            this.Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.USA_Russia, CountryOfDiscovery.UsaRussia.ToString()));
        }
    }
}
