using System;

namespace BuildDesignPattern
{
    class Program
    {
/*
        Builder Design Pattern is all about separating the construction 
        process from its representation. When the construction process of 
        your object is very complex then only you need to use to Builder 
        Design Pattern. If this is not clear at the moment then don’t 
        worry we will try to understand this with an example
        
        **********************When to Use *********************************
        1. When you want to make a complex object by specifying only its type and content. The built object is constructed from the details of its construction.
        2. When you to decouple the process of building a complex object from the parts that make up the object.
        3. When you want to isolate the code for construction and representation.
        */
        static void Main(string[] args)
        {
            Report report = null;
            ReportBuilder pdfReportBuilder = new PDFReportBuilder();
            report = ReportDirector.MakeReport(pdfReportBuilder);
            report.DisplayReport();

            ReportBuilder excelReprotBuilder = new ExcelReportBuilder();
            report = ReportDirector.MakeReport(excelReprotBuilder);
            report.DisplayReport();
        }
    }
}
