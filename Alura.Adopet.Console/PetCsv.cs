using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    public static class PetCsv
    {
        public static Pet ConvertString(this string row)
        {
            //if(row is null) throw new ArgumentNullException("não pode ser nullo");
            
            
            // separa linha usando ponto e vírgula
            string[]? propriedades = row?.Split(';') ?? throw new ArgumentNullException("não pode ser nullo");
            // cria objeto Pet a partir da separação
            return new Pet(Guid.Parse(propriedades[0]),
            propriedades[1],
            int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
