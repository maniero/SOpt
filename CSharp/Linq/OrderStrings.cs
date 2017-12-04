using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        var lista = new List<string> { "AAA", "BBB", "CCC", "ABB", "ABC", "ACC", "ACD" };
        Semelhante(lista, "A");
        Semelhante(lista, "B");
        Semelhante(lista, "C");
        Semelhante(lista, "AB");
        Semelhante(lista, "AC");
    }
    public static void Semelhante(List<string> lista, string padrao) {
        foreach (var item in lista.OrderByDescending(x => (x.Contains(padrao)))) {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

//https://pt.stackoverflow.com/q/259493/101
