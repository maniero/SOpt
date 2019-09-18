using System;
using System.Linq;

public class Program {
    public static void Main() {
        var lista = "1, 2, 3".Split(',').Select(int.Parse).ToList();
        Console.WriteLine(lista.GetType());
        foreach (var item in lista) {
            Console.WriteLine(item);
        }
    }
}

//https://pt.stackoverflow.com/q/78471/101
