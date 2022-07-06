using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge.BridgeNameFormatter
{
    internal class FancyFormatting : IFormattingType
    {
        public string FormatFirstName(string firstName)
        {
            return ApplyFancyFormatting(firstName);
        }

        public string FormatSecondName(string secondName)
        {
            return ApplyFancyFormatting(secondName);
        }

        private string ApplyFancyFormatting(string name)
        {
            StringBuilder sb = new();

            for (int i = 0; i < name.Length; i++)
            {
                if (i % 2 == 0)
                    sb.Append(name[i].ToString().ToUpper());
                else
                    sb.Append(name[i].ToString().ToLower());
            }

            return sb.ToString();
        }
    }
}
