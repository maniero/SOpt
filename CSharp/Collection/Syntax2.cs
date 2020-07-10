using System;
using static System.Console;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        var random = new Random();
        var ListaPerguntas = new List<string> { "Pergunta1", "Pergunta2", "Pergunta3", "Pergunta4" };
        WriteLine(ListaPerguntas[random.Next(ListaPerguntas.Count)]);
    }
}

//https://pt.stackoverflow.com/q/461593/101
