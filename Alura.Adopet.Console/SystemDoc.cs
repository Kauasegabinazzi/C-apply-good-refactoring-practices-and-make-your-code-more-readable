using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    public class SystemDoc
    {
        public static Dictionary<string, CommandDoc> toDictionary(Assembly assemblyTypeDoc)
        {
            return assemblyTypeDoc.GetTypes()
         .Where(t => t.GetCustomAttributes<CommandDoc>().Any())
         .Select(t => t.GetCustomAttribute<CommandDoc>()!)
         .ToDictionary(d => d.Instruction); ;
        }
    }
}
