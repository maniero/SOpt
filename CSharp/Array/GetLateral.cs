using static System.Console;

public class Program {
	public static void Main() {
		string[] linha = ReadLine().Split(' ');
		int linhas;
		if (!int.TryParse(linha[0], out linhas)) return;
		int colunas;
		if (!int.TryParse(linha[1], out colunas)) return;
		int[,] numeros = new int[linhas, colunas];
		for (int i = 0; i < linhas; i++) {
			string[] vet = ReadLine().Split(' ');
			for (int j = 0; j < colunas; j++) {
				int valor;
				if (!int.TryParse(vet[j], out valor)) return;
				numeros[i, j] = valor;
			}
		}
		string[] localizacao = new string[4];
		int num;
		if (!int.TryParse(ReadLine(), out num)) return;
		for (int i = 0; i < linhas; i++) {
			for (int j = 0; j < colunas; j++) {
				if (numeros[i, j] == num) {
					localizacao[0] = j == 0 ? "" : numeros[i, j - 1].ToString();
					localizacao[1] = j == numeros.GetUpperBound(1) ? "" : numeros[i, j + 1].ToString();
					localizacao[2] = i == 0 ? "" : numeros[i - 1, j].ToString();
					localizacao[3] = i == numeros.GetUpperBound(0) ? "" : numeros[i + 1, j].ToString();
				}
			}
		}
		WriteLine("Esquerda: " + localizacao[0]);
		WriteLine("Direita: " + localizacao[1]);
		WriteLine("Acima: " + localizacao[2]);
		WriteLine("Abaixo: " + localizacao[3]);
    }
}

//https://pt.stackoverflow.com/q/326139/101
