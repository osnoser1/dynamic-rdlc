using System;
using System.IO;
using Microsoft.Reporting.WinForms;
using Report = DynamicRdlc.Rdl.Report;

namespace DynamicRdlc
{
    public class ReportGenerator
    {
        protected readonly ReportDataSourceCollection DataSources;

        private readonly LocalReport _localReport;
        protected readonly Report Report = new Report();

        public ReportGenerator(LocalReport localReport)
        {
            if (localReport == null)
            {
                throw new ArgumentNullException(nameof(localReport));
            }

            _localReport = localReport;
            DataSources = localReport.DataSources;
        }

        public virtual void Run()
        {
            ////this.Report.Element.Save(Console.Out);  // Uncomment this to show the entire RDLC in the Output window.
            LoadReportDefinition();
        }

        private void LoadReportDefinition()
        {
            using (var stream = new MemoryStream())
            {
                Report.Element.Save(stream);
                stream.Position = 0;
                _localReport.LoadReportDefinition(stream);
            }
        }
    }
}