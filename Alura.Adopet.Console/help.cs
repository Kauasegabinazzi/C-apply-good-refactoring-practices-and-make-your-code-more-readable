using System.Reflection;
using System.Windows.Input;

namespace Alura.Adopet.Console;

[CommandDoc(instruction: "help",
 documentation: "adopet help comando que exibe informações da ajuda. \n" +
    "adopet help <NOME_COMANDO> para acessar a ajuda de um comando específico.")]
internal class Help
{
    private Dictionary<string, CommandDoc> docs;

    public Help()
    {
        docs = SystemDoc.toDictionary(Assembly.GetExecutingAssembly());
    }

    public Task ExecutarAsync(string[] args)
    {
        this.ShowHelpList(path: args);
        return Task.CompletedTask;
    }

    public void ShowHelpList(string[] path)
    {
        // se não passou mais nenhum argumento mostra help de todos os comandos
        if (path.Length == 1)
        {
            System.Console.WriteLine($"Adopet (1.0) - Aplicativo de linha de comando (CLI).");
            System.Console.WriteLine($"Realiza a importação em lote de um arquivos de pets.");
            System.Console.WriteLine($"Comando possíveis: ");
            foreach (var doc in docs.Values)
            {
                System.Console.WriteLine(doc.Documentation);
            }
        }
        // exibe o help daquele comando específico
        else if (path.Length == 2)
        {
            string comandoASerExibido = path[1];
            if (docs.ContainsKey(comandoASerExibido))
            {
                var comando = docs[comandoASerExibido];
                System.Console.WriteLine(comando.Documentation);
            }

        }
    }
}

