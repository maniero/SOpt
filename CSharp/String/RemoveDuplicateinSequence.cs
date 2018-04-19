using static System.Console;

public class Program {
	public static void Main() {
		var texto = "Abcc111de12234";
		var lista = new char[texto.Length];
		for (int i = 0, j = 0; i < texto.Length; i++) if (!char.IsDigit(texto[i]) || (i == 0 || texto[i] != texto[i - 1])) lista[j++] = texto[i];
		WriteLine(new string(lista));
	}
}

//https://pt.stackoverflow.com/q/291742/101
