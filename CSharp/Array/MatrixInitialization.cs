using static System.Console;

namespace TesteMatriz1 {
    class Program {
        static void Main(string[] args) {
            var lista = new string[,] { { "Dante", "Sparda" }, { "Vergil", "Sparda" }, { "Nero", "Sparda" } };
            for (int i = 0; i < 3; i++) for (int j = 0; j < 2; j++) WriteLine($"Nome: {lista[i, j]}");
        }
    }
}

//https://pt.stackoverflow.com/q/407464/101
