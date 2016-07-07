using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PeriodicTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rv = new ReportViewer {Dock = DockStyle.Fill};
            Controls.Add(rv);
            new PeriodicTableReportGenerator(rv.LocalReport).Run();
            rv.RefreshReport();
        }
    }
}