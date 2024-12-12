using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console
{
    public static class PetCsv
    {
        public static Pet ConvertString(this string row)
        {
            //if(row is null) throw new ArgumentNullException("não pode ser nullo");


            // separa linha usando ponto e vírgula
            string[]? propriedades = row?.Split(';') ?? throw new ArgumentNullException("não pode ser nullo");

            if (string.IsNullOrEmpty(row)) throw new ArgumentException("não pode ser vazio");

            if (propriedades.Length != 3) throw new ArgumentException("Texto invalido");

            bool sucess = Guid.TryParse(propriedades[0], out Guid id);

            if (!sucess) throw new ArgumentException("Guild invalido");

            sucess = int.TryParse(propriedades[2], out int type);
            if (!sucess) throw new ArgumentException("tipo invalido");

            if (type != 0 && type != 1) throw new ArgumentException("tipo invalido");

            // cria objeto Pet a partir da separação
            return new Pet(id,
            propriedades[1],
            type == 0 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
