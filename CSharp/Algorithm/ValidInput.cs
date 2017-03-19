using static System.Console;

public class Program {
	public static void Main(string[] args) {
        var vetor = new int[12];
		var i = 0;
        while (i < 12) {
            WriteLine("Digite um valor para o vetor");
			if (int.TryParse(ReadLine(), out var valor)) {
				WriteLine("Você digitou o caractere de forma inválida. Por favor, digite apenas númeris inteiros!");
				continue;
			}
			if (valor % 2 != 0 && valor % 3 != 0) {
                WriteLine("Apenas valores divisíveis por 2 e 3!");
				continue;
            }
            vetor[i++] = valor;
        }
        imprimeVetor(vetor);
    }
    static void imprimeVetor(int[] vetor) {
        foreach (var item in vetor) {
			Write($"{item} - ");
        }

    }
}

//http://pt.stackoverflow.com/q/191168/101
