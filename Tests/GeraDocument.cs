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
                SystemDoc.toDictionary(assemblyTypeDoc);

            NUnit.Framework.Legacy.ClassicAssert.IsNotEmpty(dicionario);
            NUnit.Framework.Legacy.ClassicAssert.NotNull(dicionario);
            NUnit.Framework.Legacy.ClassicAssert
                .Equals(4, dicionario.Count);

        }
    }
}
