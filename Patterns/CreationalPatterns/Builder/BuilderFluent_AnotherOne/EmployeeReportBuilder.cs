namespace CreationalPatterns.Builder.BuilderFluentAnotherOne;
internal class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;

    private readonly IEnumerable<Employee> _employees;

    public EmployeeReportBuilder(IEnumerable<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new();
    }

    public IEmployeeReportBuilder WithHeader()
    {
        _employeeReport.Header = $"EMPLOYEES REPORT ON DATE: {DateTime.Now}" + Environment.NewLine;

        _employeeReport.Header += Environment.NewLine + "----------------------------------------------" + Environment.NewLine;

        return this;
    }

    public IEmployeeReportBuilder WithBody()
    {
        _employeeReport.Body = string.Join(
            Environment.NewLine,
            _employees.Select(e => $"Employee: {e.Name}\t\t Salary: {e.Salary}$"));

        return this;
    }

    public IEmployeeReportBuilder WithFooter()
    {
        _employeeReport.Footer = Environment.NewLine + "----------------------------------------------";

        _employeeReport.Footer += Environment.NewLine + $"TOTAL EMPLOYEES: {_employees.Count()}, " +
            $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}$";

        return this;
    }


    public EmployeeReport GetReport()
    {
        EmployeeReport employeeReport = _employeeReport;

        _employeeReport = new();

        return employeeReport;
    }
}