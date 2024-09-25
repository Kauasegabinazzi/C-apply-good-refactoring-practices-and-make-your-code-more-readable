using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class CommandDoc : System.Attribute
    {
        public CommandDoc(string instruction, string documentation)
        {
            Instruction = instruction;
            Documentation = documentation;
        }

        public string Instruction { get; }
        public string Documentation { get; }
    }
}
