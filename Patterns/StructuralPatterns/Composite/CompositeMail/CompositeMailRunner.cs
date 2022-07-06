using StructuralPatterns.Composite.CompositeMail.MailNodes;

namespace StructuralPatterns.Composite.CompositeMail
{
    internal static class CompositeMailRunner
    {
        internal static void Run()
        {
            Mail mail = new();
            Attachments attachments = new();
            Body body = new();
            Footer footer = new();
            Attachment attachment1 = new("List of new customers.xls");
            Attachment attachment2 = new("New supplies.xls");
            Paragraph bodyParagraph1 = new() { ParagraphContent = "Dear head of product department, i'm sending you some information you was needed" };
            Paragraph footerParagraph1 = new() { ParagraphContent = "Best regards, James" };
            body.Add(bodyParagraph1);
            footer.Add(footerParagraph1);
            attachments.Add(attachment1);
            attachments.Add(attachment2);
            mail.Add(body);
            mail.Add(footer);
            mail.Add(attachments);
            Console.WriteLine($"{mail.Operation()}");
        }
    }
}
