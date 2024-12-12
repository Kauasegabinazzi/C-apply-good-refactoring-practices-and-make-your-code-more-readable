using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    [CommandDoc(instruction: "show", documentation: "adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.\" + \"\\n\\n\\n\\n\"")]
    internal class show: IComando
    {
        public Task ExeCutionAsync(string[] args)
        {
            this.showImport(args: args[1]);
            return Task.CompletedTask;
        }

        private void showImport(string args)
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
