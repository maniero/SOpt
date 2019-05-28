using static System.Console;

public class Program {
	public static void Main() {
		Compara(20, 15);
		Compara(20, 14);
		Compara(20, 11);
		Compara(20, 8);
		Compara(20, 2);
	}
	private static void Compara(int aniversario, int ano) {
		var idade = aniversario - ano;
		string texto;
		if (idade < 6) texto = "Infatil A";
		else if (idade < 7) texto = "Infantil B";
		else if (idade < 10) texto = "Juvenil A";
		else if (idade < 13) texto = "Juvenil B";
		else if (idade > 17) texto = "Adulto"; //e os que estão entre 13 e 17 não existem?
		else texto = "Não existe categoria";
		WriteLine(texto);
	}
}

//https://pt.stackoverflow.com/q/386515/101
