using static System.Console;

public class Program {
	public static void Main() {
        if (!int.TryParse(ReadLine(), out var n)) return;
        var numeros = new int[n];
        string[] entrada = ReadLine().Split(' ');
        for (var i = 0; i < n; i++) {
			if (!int.TryParse(entrada[i], out var valor)) return;
			numeros[i] = valor;
        }
        var quantidade = 0;
        for (var i = 0; i < n; i++) {
            if (numeros[i] % 2 == 0) {
                Write($"{numeros[i]} ");
                quantidade++;
            }
        }
		WriteLine();
        WriteLine(quantidade);
	}
}

//https://pt.stackoverflow.com/q/432239/101
