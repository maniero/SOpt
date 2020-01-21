using System.Linq;

public class Program {
	public static void Main() {
        var linhas = 3;
        var colunas = 3;
        var matriz = new int[linhas, colunas];
        for (int i = 0, count = 0; i < linhas; i++) for (int j = 0; j < colunas; j++) matriz[i, j] = count++;
        var vetor = matriz.OfType<int>().ToArray();
		foreach (var elem in vetor)
            System.Console.WriteLine(elem);
	}
}

//https://pt.stackoverflow.com/q/431651/101
