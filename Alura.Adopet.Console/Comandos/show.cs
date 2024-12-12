using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [CommandDoc(instruction: "show", documentation: "adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.\" + \"\\n\\n\\n\\n\"")]
    internal class show
    {
        public void showImport(string args)
        {
            readFile read = new readFile();
            var list = read.read(args);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
