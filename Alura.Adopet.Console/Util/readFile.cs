﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    internal class readFile
    {
        public List<Pet> read(string path)
        {
            // args[1] é o caminho do arquivo a ser exibido
            List<Pet> list = new List<Pet>();
            using (StreamReader sr = new StreamReader(path))
            {
                System.Console.WriteLine("----- Serão importados os dados abaixo -----");
                while (!sr.EndOfStream)
                {
                    // separa linha usando ponto e vírgula
                    string[] propriedades = sr.ReadLine().Split(';');
                    // cria objeto Pet a partir da separação
                    Pet pet = new Pet(Guid.Parse(propriedades[0]),
                    propriedades[1],
                    int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
                    );
                    list.Add(pet);
                }
            }
            return list;
        }
    }
}
