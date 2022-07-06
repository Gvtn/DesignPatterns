namespace StructuralPatterns.Composite.CompositeMail.MailNodes
{
    internal class Paragraph : Component
    {
        public string ParagraphContent { get; set; }

        public override string Operation()
        {
            return ParagraphContent;
        }
    }
}
