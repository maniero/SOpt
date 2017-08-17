using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main() {
		var selecoes = new List<string>() { "USA", "Brasil", "Itália", "França" };
        var melhorSelecao = from string s in selecoes
                where s == "Brasil"
                select s;
		foreach (var item in melhorSelecao) {
        	WriteLine(item);
		}
	}
}

//https://pt.stackoverflow.com/q/229798/101
