using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

public class Pessoa {
    public string Nome { get; set; }
    public DateTime? DataNascimento { get; set; }
    public int? Cpf { get; set; }

    public Pessoa(string nome, DateTime? dataNascimento = null, int? cpf = null){
        Nome = nome;
        DataNascimento = dataNascimento;
        Cpf = cpf;
    }
}

public class App {
    public static void Main(string[] args) {
        var limiteDeItens = 1000000;
        var pessoas = new List<Pessoa>(limiteDeItens);
        var tempo = new Stopwatch();

        tempo.Start();

        //preenche a lista
        for(var i = 0; i < limiteDeItens; i++) {
            pessoas.Add(new Pessoa("Pessoa" + i.ToString()));
        }
        tempo.Stop();
        Console.WriteLine("Preencher a lista em ms: {0}", tempo.ElapsedMilliseconds);
        // LINQ na forma declarativa
        tempo.Restart();
        var resultado1 = from pessoa in pessoas
               where pessoa.Nome.Contains('9')
               select pessoa;
        tempo.Stop();
        Console.WriteLine("Montar o LINQ declarativo em Ticks: {0}", tempo.ElapsedTicks);
        // LINQ usando sintaxe tradicional
        tempo.Restart();
        var resultado2 = pessoas.Where(x => x.Nome.Contains('9'));
        tempo.Stop();
        Console.WriteLine("Montar o LINQ imperativo em Ticks: {0}", tempo.ElapsedTicks);

        // transferir todo resultado para uma lista apenas para efeito de comparação
        var lista1 = new List<Pessoa>(limiteDeItens);
        tempo.Restart();
        foreach(var pessoa in resultado1) {
            lista1.Add(pessoa);
        }
        tempo.Stop();
        Console.WriteLine("Transferir uma lista para outra com a primeira expressão em ms: {0}", tempo.ElapsedMilliseconds);
        var lista2 = new List<Pessoa>(limiteDeItens);
        tempo.Restart();
        foreach(var pessoa in resultado1) {
            lista2.Add(pessoa);
        }
        tempo.Stop();
        Console.WriteLine("Transferir uma lista para outra com a segunda expressão em ms: {0}", tempo.ElapsedMilliseconds);

        Console.ReadKey();
    }
}

//http://pt.stackoverflow.com/q/14212/101
