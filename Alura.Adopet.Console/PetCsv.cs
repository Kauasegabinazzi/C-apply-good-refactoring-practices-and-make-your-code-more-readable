using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    public class PetCsv
    {
        public Pet ConvertString(string row)
        {
            // separa linha usando ponto e vírgula
            string[] propriedades = row.Split(';');
            // cria objeto Pet a partir da separação
            return new Pet(Guid.Parse(propriedades[0]),
            propriedades[1],
            int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
