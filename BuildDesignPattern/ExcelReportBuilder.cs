using System;

namespace BuildDesignPattern
{
    class ExcelReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportFooter = "Excel Report Type";
        }
    }
}