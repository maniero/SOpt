using static System.Console;

public class Program {
	public static void Main() {
		int menor = int.MaxValue, maior = 0;
		for (int i = 0; i < 5; i++) {
			WriteLine("informe o valor: ");
			if (!int.TryParse(ReadLine(), out var valor)) WriteLine("valor inválido");
			if (valor <= menor) menor = valor;
			if (valor >= maior) maior = valor;
		}
		WriteLine("MAIOR: " + maior);
		WriteLine("MENOR: " + menor);
	}
}
//https://pt.stackoverflow.com/q/393955/101
