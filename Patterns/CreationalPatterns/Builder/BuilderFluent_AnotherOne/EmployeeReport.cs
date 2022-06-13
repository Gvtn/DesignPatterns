using System.Text;

namespace CreationalPatterns.Builder.BuilderFluentAnotherOne;
internal class EmployeeReport
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .ToString();
    }