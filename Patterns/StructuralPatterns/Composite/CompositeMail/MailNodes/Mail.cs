using System.Text;

namespace StructuralPatterns.Composite.CompositeMail.MailNodes
{
    internal class Mail : Component
    {
        protected List<Component> _children = new List<Component>();

        public override string Operation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<Mail>");

            foreach (var item in _children)
            {
                sb.Append($"{item.Operation()}");
            }
            sb.AppendLine("<End of mail>");

            return sb.ToString();
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
    }
}
