using static System.Console;

public class Program {
	public static Naipe Naipe { get; set; }
	public static void Main() {
		Naipe = Naipe.Copas;
		WriteLine($"{(char)Naipe.Espada} {(char)Naipe.Paus} {(char)Naipe.Copas} {(char)Naipe.Ouro} {(char)Naipe}");
	}
}

public enum Naipe { Espada = 9824, Paus = 9827, Copas = 9829, Ouro }

//https://pt.stackoverflow.com/q/263454/101
