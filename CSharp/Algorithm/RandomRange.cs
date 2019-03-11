using System;
using static System.Console;

namespace ConsoleApplication1 {
    public class Program {
        public static void Main() {
            var numeros = new int[6];
            var rdm = new Random();
            for (int i = 1; i <= 1_000_000; i++) {
                WriteLine($"girei pela: {i}a. vez");
                numeros[rdm.Next(6)]++;
            }
            for (var i = 0; i < numeros.Length; i++) WriteLine($"Quantidade de vezes que o N° {i + 1} foi sorteado: {numeros[i]}");
        }
    }
}

//https://pt.stackoverflow.com/q/366885/101
