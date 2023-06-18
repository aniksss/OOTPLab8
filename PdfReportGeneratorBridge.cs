public class PdfReportGeneratorBridge : IReportGeneratorBridge
{
    public void GenerateReport(List<string> dataSet, List<string> filters, string sortBy, bool ascending)
    {
        Console.WriteLine("PDF report generated with parameters: " + String.Join(", ", dataSet) + " and filters: " + String.Join(", ", filters));
    }
}