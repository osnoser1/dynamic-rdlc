namespace PeriodicTable
{
    using System.Windows.Forms;

    using Microsoft.Reporting.WinForms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var rv = new ReportViewer { Dock = DockStyle.Fill };
            this.Controls.Add(rv);
            new PeriodicTableReportGenerator(rv.LocalReport).Run();
            rv.RefreshReport();
        }
    }
}
