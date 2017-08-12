using System;
using static System.Console;
using System.Collections.Generic;

public class Program {
    public static void Main(string[] args) {
        var numeros = new List<int>();
        var pares = new List<int>();
        var impares = new List<int>();
        var random = new Random();
        for(int i = 0; i < 20; i++) numeros.Add(random.Next(1, 99));
        foreach (int item in numeros) {
			if ((item & 1) == 0) {
                pares.Add(item);
			} else {
                impares.Add(item);
			}
        }
        WriteLine("Todos os números:");
        for (int i = 0; i < numeros.Count - 1; i++) Write(numeros[i] + ", ");
        WriteLine(numeros[numeros.Count - 1] + ".");
        WriteLine("\nNúmeros pares:");
        for (int i = 0; i < pares.Count - 1; i++) Write(pares[i] + ", ");
        WriteLine(pares[pares.Count - 1] + ".");
        WriteLine("\nNúmeros ímpares:");
        for (int i = 0; i < impares.Count - 1; i++) Write(impares[i] + ", ");
        WriteLine(impares[impares.Count - 1] + ".");
    }
}

//https://pt.stackoverflow.com/q/228584/101
