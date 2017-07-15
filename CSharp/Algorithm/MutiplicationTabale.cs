using static System.Console;

public class Program {
	public static void Main(string[] args) {    
		int continuar = 1;
		while (continuar == 1) {    
			WriteLine("Digite um numero de 1 a 10: ");
			int valor;    
			if (int.TryParse(ReadLine(), out valor) && valor >= 1 && valor <= 10) {
				for (int cont = 1; cont <= 10; cont++) {    
					WriteLine($"{valor:D2} X {cont:D2} = {valor * cont:D2}");
				}
	
				WriteLine("Deseja verificar a tabuada de algum outro número? Digite 1 para SIM ou 2 para NAO");
				if (int.TryParse(ReadLine(), out continuar)) continuar = 2;
			} else {
				WriteLine("Número inválido! ");
			}
		}
	}
}

//https://pt.stackoverflow.com/q/220540/101
