using static System.Console;

public class Program {
	public static void Main() {
		int multiplicador = 1, multiplicando = 1;     
		WriteLine("Digite um número: ");
		//if (!int.TryParse(ReadLine(), out var valor)) return;
		int valor = 10;
		while (multiplicador <= valor) {
			WriteLine($"##### TABUADA DE {multiplicador} #####");
			while (multiplicando <= valor) {
				WriteLine($"{multiplicando} x {multiplicador} = {multiplicando * multiplicador}");
				multiplicando++;
			}
			multiplicador++;
			multiplicando = 1;
		}
	}
}

//https://pt.stackoverflow.com/q/532280/101
