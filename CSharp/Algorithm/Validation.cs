using static System.Console;

public class Program {
public static void Main() {
	var idArtista = 0;
	while (true) {
		WriteLine("Digite o ID do artista:");
		if (int.TryParse(ReadLine(), out idArtista)) break;
	}
	WriteLine("Digite o nome do artista:");
	var nomeArtista = ReadLine();
	WriteLine("Digite o sobrenome do artista:");
	var  sobrenomeArtista = ReadLine();
	var  idReparador = 0;
	while (true) {
		WriteLine("Digite o ID do reparador:");
		if (int.TryParse(ReadLine(), out idReparador) && idArtista != idReparador) break;
	}
}
}

//https://pt.stackoverflow.com/q/235052/101
