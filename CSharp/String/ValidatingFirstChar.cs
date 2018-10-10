using static System.Console;

public class Program {
	public static void Main() {
		Write("Digite o nome do rei: " );
        while (true) {
            var king = ReadLine();
			if (king.Length > 0 && king.Length < 21 && char.IsUpper(king[0])) break;
			WriteLine("O nome está inválido\nDigite novamente");	
        }
	}
}

//https://pt.stackoverflow.com/q/335663/101
