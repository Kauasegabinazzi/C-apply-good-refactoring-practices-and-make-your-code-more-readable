using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Console.Comandos
{
    [CommandDoc(instruction: "list", documentation: "adopet list comando que exibe no terminal o conteúdo cadastrado na base de dados da AdoPet.\" + \"\\n\"")]
    internal class list
    {
        public async Task ListaDadosPetsDaAPIAsync()
        {
            var httpListPet = new HttpClientPet();
            IEnumerable<Pet>? pets = await httpListPet.ListPetsAsync();
            System.Console.WriteLine("----- Lista de Pets importados no sistema -----");
            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }

    }
}
