using static System.Console;

namespace vetor {
    public class Program {
        public static void Main() {
            int[] vet = new int[3];
            for (int i = 0; i < vet.Length; i++) {
                WriteLine("Digite o numero: ");
                vet[i] = int.Parse(ReadLine());
            }
            for (int a = 0; a < vet.Length; a++) WriteLine($"{vet[a]}");
        }
    }
}

//https://pt.stackoverflow.com/q/175261/101
