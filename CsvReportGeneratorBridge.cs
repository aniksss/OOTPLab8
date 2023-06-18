public class CsvReportGeneratorBridge : IReportGeneratorBridge
{
    public void GenerateReport(List<string> dataSet, List<string> filters, string sortBy, bool ascending)
    {
        Console.WriteLine("CSV report generated with parameters: " + String.Join(", ", dataSet) + " and filters: " + String.Join(", ", filters));
    }
}