public class ReportGenerator : IReportGenerator
{
    private List<string> _dataSet;
    private string _format;
    private List<string> _filters;
    private string _sortBy;
    private bool _ascending;

    public ReportGenerator()
    {
        _dataSet = new List<string>();
        _format = "";
        _filters = new List<string>();
        _sortBy = "";
        _ascending = true;
        Console.WriteLine("ReportGenerator created.");
    }

    public void SetFormat(string format)
    {
        _format = format;
        Console.WriteLine("Format set to " + format);
    }

    public void SetFilters(List<string> filters)
    {
        _filters = filters;
        Console.WriteLine("Filters set to " + String.Join(", ", filters));
    }

    public void SetSortBy(string sortBy, bool ascending)
    {
        _sortBy = sortBy;
        _ascending = ascending;
        Console.WriteLine("Sorting set to " + sortBy + (ascending ? " in ascending order" : " in descending order"));
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating report...");
        IReportGeneratorBridge reportGeneratorBridge;
        switch (_format)
        {
            case "PDF":
                reportGeneratorBridge = new PdfReportGeneratorBridge();
                break;
            case "CSV":
                reportGeneratorBridge = new CsvReportGeneratorBridge();
                break;
            case "Excel":
                reportGeneratorBridge = new ExcelReportGeneratorBridge();
                break;
            default:
                throw new Exception("Invalid report format specified.");
        }
        reportGeneratorBridge.GenerateReport(_dataSet, _filters, _sortBy, _ascending);
    }
}