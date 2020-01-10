using static System.Console;
using System.Linq;
					
public class Program {
	public static void Main() {
		var txtFiltro = "noivas,unhas";
		var lista = new[] {
			new{Nome_Grupo = "Noivas de Plantão"},
			new{Nome_Grupo = "Noivas 2016/ 2017 - RJ"},
			new{Nome_Grupo = "Noivas Goianas"},
			new{Nome_Grupo = "NOIVA FELIZ-Compra,venda e troca de acessórios e vestidos de noivas."},
			new{Nome_Grupo = "DEUS ACIMA DE TUDO"},
			new{Nome_Grupo = "No Colo De Nossa Senhora"},
			new{Nome_Grupo = "Aqui tem uma frase com unhas"},
		};
		var palavrasFiltro = txtFiltro.ToLower().Split(',');
		var matches = lista.Where(x => !x.Nome_Grupo.ToLower().ContainsAny(palavrasFiltro)).ToList();
		matches.ForEach(WriteLine);
	}
}

public static class StringExt {
	public static bool ContainsAny(this string haystack, params string[] needles) {
		foreach (var needle in needles) {
			if (haystack.Contains(needle)) return true;
		}
		return false;
	}
}

//https://pt.stackoverflow.com/q/128150/101
