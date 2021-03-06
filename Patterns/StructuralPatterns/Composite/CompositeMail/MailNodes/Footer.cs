using System.Text;

namespace StructuralPatterns.Composite.CompositeMail.MailNodes
{
    internal class Footer : Component
    {
        protected List<Component> _children = new List<Component>();

        public override string Operation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t<Footer>");

            foreach (var item in _children)
            {
                sb.AppendLine($"\t\t{item.Operation()}");
            }
            sb.AppendLine("\t<End of footer>");

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
