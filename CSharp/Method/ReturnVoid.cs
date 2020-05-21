using static System.Console;
					
public class Program {
    public static void Main() {
        WriteLine("Digite um numero: ");
        var numero = ReadLine();
        WriteLine("Digite uma letra: (opcional)");
        var letra = ReadLine();
        WriteLine("O resultado é");
		MostraNaTela(numero, letra);
    }
    public static void MostraNaTela(string num) => WriteLine($"O numero é {num} Não foi preenchido letra");

	public static void MostraNaTela(string numero, string letra) {
        WriteLine(numero);
        WriteLine(letra);
    }
}

//https://pt.stackoverflow.com/q/452961/101
