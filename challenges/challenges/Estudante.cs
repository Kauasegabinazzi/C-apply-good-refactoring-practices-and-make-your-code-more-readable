using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace challenges;

public class Estudante
{

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Matricula { get; set; }

    public void ImprimirDados(string nome = "", int idade = 0, string matricula = "")
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + (idade));
        Console.WriteLine("Matricula: " + (matricula));
    }

    internal void Show()
    {

        var joao = new Estudante();
        List<Estudante> args = new List<Estudante>();

        joao.ImprimirDados(nome: args[0].Nome, idade: args[1].Idade, matricula: args[2].Matricula);
    }

}

