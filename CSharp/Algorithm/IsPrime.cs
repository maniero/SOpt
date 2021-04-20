using static System.Console;
using static System.Math;

namespace Vetor1 {
    class Program {
        static int Main(string[] args) {
            var vetor = new int[10];
            for (int i = 0; i < vetor.Length; i++) {
                do {
                    Write($"Digite o {i}° número: ");
                    if (!int.TryParse(ReadLine(), out vetor[i])) {
                        WriteLine("Valor inválido, tente de novo.");
                        continue;
                    }
                } while (vetor[i] < -1);
            }
            for (int i = 0; i < vetor.Length; i++) if (EhPrimo(vetor[i])) WriteLine($"Posição {i}");
            return 0;
        }
        public static bool EhPrimo(int numero) {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;
            var limite = (int)Floor(Sqrt(numero));
            for (int i = 3; i <= limite; i += 2) if (numero % i == 0) return false;
            return true;        
        }
    }
}

//https://pt.stackoverflow.com/q/412410/101
