using static System.Console;

public class Program {
	public static void Main() {
		Compara(20, 15);
		Compara(20, 14);
		Compara(20, 11);
		Compara(20, 8);
		Compara(20, 2);
	}
	private static void Compara(int aniversario, int ano) => WriteLine((aniversario - ano) switch {
		    < 6 => "Infatil A",
		    < 7 => "Infantil B",
		    < 10 => "Juvenil A",
		    < 13 => "Juvenil B",
		    > 17 => "Adulto",
		    _ =>  "Não existe categoria",
		});
}

//https://pt.stackoverflow.com/q/386515/101
