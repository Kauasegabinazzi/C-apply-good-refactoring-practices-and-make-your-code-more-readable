using Alura.Adopet.Console;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class GeraDocument
    {
        [Fact]
        public void WhenExistCommand()
        {

            Assembly assemblyTypeDoc = Assembly.
                GetAssembly(typeof(CommandDoc))!;

            Dictionary<string, CommandDoc> dicionario =
                DocumentationSystem.toDictionary(assemblyTypeDoc);

            NUnit.Framework.Legacy.ClassicAssert.IsNotEmpty(dicionario);
        }
    }
}
