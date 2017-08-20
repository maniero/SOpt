using static System.Console;

public class Test {
    public static void Main() {
		const int tamanho = 5;
        var atividade = new int[tamanho];
		var i = 0;
        while (i < tamanho) {
            WriteLine($"Insira o {i}° numero: ");
			if (int.TryParse(ReadLine(), out atividade[i])) {
				i++;
			}
        }
		WriteLine("Os seguintes numeros foram digitados: ");
		foreach (var item in atividade) {
			WriteLine($"{item} é {((item & 1) == 0 ? "par" : "impar")}");
		}
    }
}

//https://pt.stackoverflow.com/q/230567/101
