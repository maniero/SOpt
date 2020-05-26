using static System.Console;

namespace Calculadora {
    public class Program {
        public static void Main(string[] args) {
			WriteLine("Digite o primeiro numero.");
			if (!double.TryParse(ReadLine(), out var n1)) {
				WriteLine("Dado digitado inválido");
				return;
			}
			WriteLine("Digite o segundo numero.");
			if (!double.TryParse(ReadLine(), out var n2)) {
				WriteLine("Dado digitado inválido");
				return;
			}
			double multiplicacao = n1 * n2;
			WriteLine("Resultado...");
			WriteLine($"{n1} * {n2} = {multiplicacao}");
            WriteLine("Tudo foi executado...");
        }
    }
}

//https://pt.stackoverflow.com/q/215379/101
