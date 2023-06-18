public class ExcelReportGeneratorBridge : IReportGeneratorBridge
{
    public void GenerateReport(List<string> dataSet, List<string> filters, string sortBy, bool ascending)
    {
        Console.WriteLine("Excel report generated with parameters: " + String.Join(", ", dataSet) + " and filters: " + String.Join(", ", filters));
    }
}