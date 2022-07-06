namespace StructuralPatterns.Composite.CompositeMail.MailNodes
{
    internal class Attachment : Component
    {
        public string Name { get; set; }
        public Attachment(string name)
        {
            Name = name;
        }
        public override string Operation()
        {
            return $"- {Name}";
        }
    }
}
