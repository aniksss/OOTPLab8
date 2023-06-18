public class ReportGeneratorFacade
{
    private ReportGenerator _reportGenerator;
    private SecurityManager _securityManager;

    public ReportGeneratorFacade()
    {
        _reportGenerator = new ReportGenerator();
        _securityManager = new SecurityManager();
        Console.WriteLine("ReportGeneratorFacade created.");
    }

    public void GenerateReport(string format, List<string> filters, string sortBy, bool ascending)
    {
        Console.WriteLine("Generating report...");
        if (!_securityManager.CheckPermissions())
        {
            throw new Exception("User does not have permissions to generate reports.");
        }
        _reportGenerator.SetFilters(filters);
        _reportGenerator.SetSortBy(sortBy, ascending);
        _reportGenerator.SetFormat(format);
        _reportGenerator.GenerateReport();
    }
}