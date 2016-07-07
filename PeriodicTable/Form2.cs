using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PeriodicTable
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var rv = new ReportViewer {Dock = DockStyle.Fill};
            rv.LocalReport.ReportEmbeddedResource = "PeriodicTable.Report.Report1.rdlc";
            Controls.Add(rv);

            rv.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", MainTableDataSource.Create()));
            rv.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet2", SubTableDataSource.Create()));

            rv.RefreshReport();
        }
    }
}