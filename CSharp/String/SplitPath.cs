using static System.Console;
					
public class Program
{
	public static void Main()
	{
		var texto = "~/Areas/Teste/Views/home/index.cshtml";
		var inicioPalavra = texto.IndexOf('/', texto.IndexOf('/') + 1);
		var palavra = texto.Substring(inicioPalavra + 1, texto.IndexOf('/', inicioPalavra + 1) - inicioPalavra - 1);
		WriteLine(palavra);
		//segunda forma
		var palavras = texto.Split('/');
		WriteLine(palavras[2]);
	}
}

//https://pt.stackoverflow.com/q/35400/101
