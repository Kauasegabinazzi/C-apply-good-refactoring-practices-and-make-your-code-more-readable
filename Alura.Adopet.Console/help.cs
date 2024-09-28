using System.Reflection;

namespace Alura.Adopet.Console;

[CommandDoc(instruction: "help", documentation: "adopet help comando que exibe informações da ajuda.")]
internal class help
{
    private Dictionary<string, CommandDoc> docs;
    public help()
    {
        docs = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.GetCustomAttributes<CommandDoc>().Any())
            .Select(t => t.GetCustomAttribute<CommandDoc>()!)
            .ToDictionary(d => d.Instruction);
    }

    public void ShowHelpList(string[] path)
    {
        System.Console.WriteLine("Lista de comandos.");

        if (path.Length == 1)
        {
            System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help  " +
                 "comando que exibe informações de ajuda dos comandos.");
            System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
            System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
            System.Console.WriteLine("Comando possíveis: ");
            //System.Console.WriteLine($" adopet help comando que exibe informações da ajuda.");
            //System.Console.WriteLine($" adopet import <arquivo> comando que realiza a importação do arquivo de pets.");
            //System.Console.WriteLine($" adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado." + "\n\n\n\n");
            //System.Console.WriteLine("Execute 'adopet.exe help [comando]' para obter mais informações sobre um comando." + "\n\n\n");
            //System.Console.WriteLine($" adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet." + "\n");

            foreach (var doc in docs.Values)
            {
                System.Console.WriteLine(doc.Documentation);
            }
        }
        // exibe o help daquele comando específico
        else if (path.Length == 2)
        {
            string commandToShow = path[1];
            if (docs.ContainsKey(commandToShow))
            {
                var command = docs[commandToShow];
                System.Console.WriteLine(command);
            }

            //if (path.Equals("import"))
            //{
            //    System.Console.WriteLine(" adopet import <arquivo> " +
            //        "comando que realiza a importação do arquivo de pets.");
            //}
            //if (path.Equals("show"))
            //{
            //    System.Console.WriteLine(" adopet show <arquivo>  comando que " +
            //        "exibe no terminal o conteúdo do arquivo importado.");
            //}
            //if (path.Equals("list"))
            //{
            //    System.Console.WriteLine(" adopet list <arquivo>  comando que " +
            //        "exibe no terminal o conteúdo do arquivo importado.");
            //}
        }
    }
}

