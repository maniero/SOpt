using static System.Console;

namespace TesteVetor {
    class Program4 {
        static void Main() {
            var vetor1 = new int[5];
            var vetor2 = new int[5];
            var vetor3 = new int[10];
            for (int i = 0; i < vetor1.GetLength(0); i++) {
                Write($"Digite o {i}° número do vetor 1: ");
                vetor1[i] = int.Parse(ReadLine());
            }
            WriteLine();
            for (int i = 0; i < vetor2.GetLength(0); i++) {
                Write($"Digite o {i}° número do vetor 2: ");
                vetor2[i] = int.Parse(ReadLine());
            }
            for (int i = 0, j = 0; i < 5; i++) {
                vetor3[j++] = vetor1[i];
                vetor3[j++] = vetor2[i];
            }
            for (int i = 0; i < vetor3.GetLength(0); i++) WriteLine($"{vetor3[i]}");
        }
    }
}

//https://pt.stackoverflow.com/q/413430/101
