using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var parametros = new List<Parametro>(){
		    new Parametro(){
			    Nome = "parametro1",
			    Valor = "Programando em C#"
		    },
		    new Parametro(){
			    Nome = "parametro2",
			    Valor = "preciso de ajuda!"
		    }
		};
		var texto = "Texto dinâmico {{parametro1}} , mais um pedaço do texto {{parametro2}}";
		foreach (var item in parametros) texto = texto.Replace("{{" + item.Nome.Trim() + "}}", item.Valor);
		WriteLine(texto);
		WriteLine(texto.Interpolate(parametros));
	}
}

public static class StringExt {
	public static string Interpolate(this string text, List<Parametro> parameters) {
		foreach (var item in parameters) text = text.Replace("{{" + item.Nome.Trim() + "}}", item.Valor);
		return text;		
	}
}

public class Parametro {
	public string Nome;
	public string Valor;
}

//https://pt.stackoverflow.com/q/133419/101
