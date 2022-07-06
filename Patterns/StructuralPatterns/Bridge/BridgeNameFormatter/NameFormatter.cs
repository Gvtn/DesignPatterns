using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge.BridgeNameFormatter
{
    internal class NameFormatter : INameFormatter
    {
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public IFormattingType FormattingType { get; set; }

        public NameFormatter(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }
        public void FormatName()
        {
            if (FormattingType == null)
                throw new ArgumentNullException(nameof(FormattingType));

            Console.WriteLine($"{FormattingType.FormatFirstName(FirstName)} {FormattingType.FormatSecondName(SecondName)}");
        }
    }

    interface INameFormatter
    {
        public void FormatName();
        IFormattingType FormattingType { get; set; }
    }

    interface IFormattingType
    {
        string FormatFirstName(string firstName);
        string FormatSecondName(string secondName);
    }
}
