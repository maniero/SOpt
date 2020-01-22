using static System.Console;

public class Program {
	public static void Main() {
		var texto = "kkkkkkkkkkkk jjjjjjjjjjj oloco icaro alguma coisa algumas palavras várias loucuras name:'icaro' lalala huhuasd sdiufhidf sdifuhisuhdf kkkkkkk";
		WriteLine(StringPick(texto, "name:'", '\'')); //provavelmente é uma má ideia colocar a abertura do delimitador junto com a tag
		WriteLine(StringPick(texto, "age:'", '\'')); //não achou a tag
		WriteLine(StringPick(texto, "name:'", ',')); //não achou o demimitador
	}
	public static string StringPick(string text, string tag, char closing) {
		int index = text.IndexOf(tag);
		int start = index + tag.Length;
		int end = text.IndexOf(closing, start + 1);
		return index >= 0 ? text.Substring(start, (end >= 0 ? end : text.Length) - start) : "";
	}
}

//https://pt.stackoverflow.com/q/135518/101
