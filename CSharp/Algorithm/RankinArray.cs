using static System.Console;
					
public class Program {
	public static void Main() {
		var textBoxRankTecnica = "C+";
		string[] ranksAceitaveis = new string[] { "E", "E+", "D", "D+", "C", "C+", "B", "B+", "A", "A+", "S", "S+", "S++" };
        for (int i = 0; i < ranksAceitaveis.Length; i++) {
            if (textBoxRankTecnica == ranksAceitaveis[i]) {
				WriteLine("O Rank digitado é válido");
                break;
            }
        }
		
	}
}

//http://pt.stackoverflow.com/q/186740/101
