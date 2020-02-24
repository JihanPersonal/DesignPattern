using System;

namespace BuildDesignPattern
{
    class PDFReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF Report Type";
        }
    }
}