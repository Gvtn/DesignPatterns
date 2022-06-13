namespace CreationalPatterns.Builder.BuilderFluentAnotherOne;
internal interface IEmployeeReportBuilder
{
    IEmployeeReportBuilder WithHeader();

    IEmployeeReportBuilder WithBody();

    IEmployeeReportBuilder WithFooter();

    EmployeeReport GetReport();
}
