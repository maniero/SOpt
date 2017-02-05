using static System.Console;

namespace exercicio32 {
	public class exercicio32 {
		public static void Main(string[] args) {
			int[] numeros = new int[args.Length];
			for (int i = 0; i < args.Length; i++)	{
			    int numero;
			    if (int.TryParse(args[i], out numero)) {
				    numeros[i] = numero;
			    } else {
			        WriteLine("Dado inválido! Digite apenas números separados por espaço");
			    }
			}
			Write("Vetor: ");
			for (int i = 0; i < args.Length; i++) {
				Write($"{numeros[i]} ");
			}
			OrdernaVetor(numeros);
			WriteLine("\nVetor Ordenado: ");
			for (int i = 0; i < args.Length; i++) {
				Write($"{numeros[i]} ");
			}
		}
		public static void OrdernaVetor(int[] vetor) {
			for (int i = 0; i < vetor.Length; i++) {
				for (int j = 0; j < vetor.Length - 1; j++) {
					if (vetor[j] > vetor[j + 1]) {
					    int temp = vetor[j + 1];
						vetor[j + 1] = vetor[j];
						vetor[j] = temp;
					}
				}
			}
		}
	}
}

//http://pt.stackoverflow.com/q/182249/101
