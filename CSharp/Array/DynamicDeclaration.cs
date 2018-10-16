using static System.Console;

public class Program {
	public static void Main() {
        Write("Linha: ");
        if (!int.TryParse(ReadLine(), out var linhas)) return;
        Write("Coluna: ");
        if (!int.TryParse(ReadLine(), out var colunas)) return;
        var matriz = new double[linhas, colunas];
        for (int i = 0; i < linhas; i++) {  
            for (int j = 0; j < colunas; j++) {
                Write("Digite um valor: ");
				if (!double.TryParse(ReadLine(), out var valor)) return;
                matriz[i, j] = valor; 
            }
        }
        WriteLine("\n\n");
        for (int i = 0; i < linhas; i++) {
            for (int j = 0; j < colunas; j++) Write(matriz[i, j] + " ");
            WriteLine(" ");
        }
	}
}

//https://dotnetfiddle.net/I84Vpb
