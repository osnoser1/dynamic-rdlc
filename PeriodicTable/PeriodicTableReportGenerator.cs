using DynamicRdlc;
using DynamicRdlc.Rdl;
using Microsoft.Reporting.WinForms;
using PeriodicTable.Properties;

namespace PeriodicTable
{
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
            Report.AddReportSection(new ReportSection(body));

            Report.AddDataSet(dataSetForMainTable);
            Report.AddDataSet(dataSetForSubTable);
            DataSources.Add(new ReportDataSource(dataSetForMainTable.Name, MainTableDataSource.Create()));
            DataSources.Add(new ReportDataSource(dataSetForSubTable.Name, SubTableDataSource.Create()));

            CreateEmbeddedImages();

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
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.NoBackground, CountryOfDiscovery.Undiscovered.ToString()));
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Aristotle, CountryOfDiscovery.KnownToAncients.ToString()));
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Aristotle_Germany, CountryOfDiscovery.KnownToAncientsGermany.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Austria, CountryOfDiscovery.Austria.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Denmark, CountryOfDiscovery.Denmark.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Finland, CountryOfDiscovery.Finland.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.France, CountryOfDiscovery.France.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Germany, CountryOfDiscovery.Germany.ToString()));
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Germany_Sweden, CountryOfDiscovery.GermanySweden.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Italy, CountryOfDiscovery.Italy.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Romania, CountryOfDiscovery.Romania.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Russia, CountryOfDiscovery.Russia.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Spain, CountryOfDiscovery.Spain.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.Sweden, CountryOfDiscovery.Sweden.ToString()));
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.Switzerland, CountryOfDiscovery.Switzerland.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.UK, CountryOfDiscovery.Uk.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.UK_France, CountryOfDiscovery.UkFrance.ToString()));
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.UK_Germany, CountryOfDiscovery.UkGermany.ToString()));
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.UK_Sweden_France, CountryOfDiscovery.UkSwedenFrance.ToString()));
            Report.AddEmbeddedImage(new EmbeddedImage(Resources.USA, CountryOfDiscovery.Usa.ToString()));
            Report.AddEmbeddedImage(
                new EmbeddedImage(Resources.USA_Russia, CountryOfDiscovery.UsaRussia.ToString()));
        }
    }
}