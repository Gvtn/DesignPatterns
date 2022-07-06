using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge.BridgeNameFormatter
{
    internal class LowercaseFormatting : IFormattingType
    {
        public string FormatFirstName(string firstName)
        {
            return firstName.ToLower();
        }

        public string FormatSecondName(string secondName)
        {
            return secondName.ToLower();
        }
    }
}
