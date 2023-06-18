public class ReportGeneratorProxy : IReportGenerator
{
    private ReportGenerator _reportGenerator;
    private SecurityManager _securityManager;

    public ReportGeneratorProxy()
    {
        _reportGenerator = new ReportGenerator();
        _securityManager = new SecurityManager();
        Console.WriteLine("ReportGeneratorProxy created.");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating report via proxy...");
        if (!_securityManager.CheckPermissions())
        {
            throw new Exception("User does not have permissions to generate reports.");
        }
        _reportGenerator.GenerateReport();
    }
}