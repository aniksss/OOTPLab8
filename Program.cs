using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting the program...");
        ReportGeneratorFacade reportGeneratorFacade = new ReportGeneratorFacade();
        List<string> filters = new List<string> { "Type = 'A'", "Status = 'Active'" };
        string sortBy = "Name";
        bool ascending = true;
        try
        {
            reportGeneratorFacade.GenerateReport("CSV", filters, sortBy, ascending);
            Console.WriteLine("Report generated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error generating report: " + ex.Message);
        }
        Console.ReadLine();
    }
}
