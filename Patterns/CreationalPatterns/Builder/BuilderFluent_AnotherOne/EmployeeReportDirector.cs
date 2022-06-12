namespace CreationalPatterns.Builder.BuilderFluentAnotherOne;
internal class EmployeeReportDirector
{
    private readonly IEmployeeReportBuilder _builder;

    public EmployeeReportDirector(IEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.WithHeader().WithBody().WithFooter();
    }
}
