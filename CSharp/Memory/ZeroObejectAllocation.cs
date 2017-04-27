using System;

class Program {
    static void Main() {
        var memoriaAnterior = GC.GetTotalMemory(true);
        Console.WriteLine(memoriaAnterior);
        var array = new None[1000000];
        var memoriaAtual = GC.GetTotalMemory(true);
        Console.WriteLine(memoriaAtual);
        Console.WriteLine($"Diferença: { memoriaAtual - memoriaAnterior }");
        Console.WriteLine(array.Length);
    }
}

struct None {}

//https://pt.stackoverflow.com/q/200957/101 
