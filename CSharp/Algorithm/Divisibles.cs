using static System.Console;

namespace revisao {
    public class Program {   
		public static void Main(string[] args) {
            Write("Digite o tamanho do vetor: ");
			if (int.TryParse(ReadLine(), out var tamanho)) {
				int[] vetor = new int[tamanho];
				for(int i = 0; i < vetor.Length; i++) {
					Write($"Digite o elemento {i}: ");
					vetor[i] = int.TryParse(ReadLine(), out var valor) ? valor : 0;
				}
                Imprimir(vetor);
			}
        }
        private static void Imprimir(int[] vetor) {
			WriteLine("Valores divisíveis por 2 e 3 simultaneamente");
			foreach (var item in vetor) {
                if (item % 6 == 0) {
                    WriteLine($"{item}");
				}
            }
        }
    }
}

//https://pt.stackoverflow.com/q/244426/101
