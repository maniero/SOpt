using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        var lista = new List<string> { "AAA", "BBB", "CCC", "ABB", "ABC", "ACC", "ACD" };
        var padrao = "A";
        foreach (var item in lista.OrderByDescending(x => x.Select((c, i) => x.Substring(i)).Count(sub => sub.StartsWith(padrao)))) {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        padrao = "AB";
        foreach (var item in lista.OrderByDescending(x => x.Select((c, i) => x.Substring(i)).Count(sub => sub.StartsWith(padrao)))) {
            Console.WriteLine(item);
        }
    }
}

//https://pt.stackoverflow.com/q/259493/101
