using static System.Console;

public class Program {
	public static void Main(string[] args) {
		var texto1 = ReadLine(); //pede o texto e armazena em variável
		int numero1; //declara a variável que recebrá o número1
		var texto2 = ReadLine(); //pede o texto e armazena em variável
		int numero2; //declara a variável que recebrá o número2
		if (int.TryParse(texto1, out numero1) && int.TryParse(texto2, out numero2)) WriteLine($"{texto1} + {texto2} = {numero1 + numero2}");
	}
}

//https://pt.stackoverflow.com/q/171612/101
