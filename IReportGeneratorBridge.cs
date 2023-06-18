public interface IReportGeneratorBridge
{
    void GenerateReport(List<string> dataSet, List<string> filters, string sortBy, bool ascending);
}