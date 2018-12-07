using static System.Console;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        Pessoa.Lista();
    }
}

public class Pessoa {
    public int ID { get; set; }
    public string Nome1 { get; set; }
    public string Nome2 { get; set; }
    public static List<Pessoa> Pessoas { get; set; } = new List<Pessoa>();
    public static void Lista() {
        for (var i = 0; i < Pessoas.Count; i++) WriteLine(Pessoas[i].Nome1 + (i + 1).ToString());
    }
}

//https://pt.stackoverflow.com/q/348156/101
