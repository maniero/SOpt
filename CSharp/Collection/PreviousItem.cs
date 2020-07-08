using static System.Console;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        var lista = new List<int>() { 1, 2, 3, 4 };
        var anterior = 0;
        foreach (var item in lista) {
            WriteLine($"Soma o atual e anterior { anterior + item }");
            anterior = item;
        }
    }
}

//https://pt.stackoverflow.com/q/271540/101
