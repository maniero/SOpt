using static System.Console;

public class Program {
	public static void Main(string[] args) {
		string texto = "Este é um teste de texto longo que precisa ser truncado com reticências, sem cortar a palavra.";
		for (int i = 0; i < texto.Length + 1; ++i) WriteLine($"{i} : {texto.Ellipsis(i)}");
	}
}

public static class StringExt {
	static public string Ellipsis(this string text, int length, string ellipsis = "...") {
		if (text.Length <= length) return text;
		if (length <= ellipsis.Length) return ellipsis.Substring(0, length);
		text = text.Substring(0, length - ellipsis.Length);
		var position = text.LastIndexOf(' ');
		position = position < 0 ? 0 : position;
		return text.Substring(0, position).Trim(new[] { '.', ',', ';', ':', '!', '?' }) + ellipsis;
	}
}

//https://pt.stackoverflow.com/q/155204/101
