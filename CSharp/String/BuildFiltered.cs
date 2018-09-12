using static System.Console;
using System.Text;

public class Program {
	public static void Main() {
		var hs = "/4587 / 5458/";
		var texto = new StringBuilder(hs.Length);
		var digito = true;
		foreach (var chr in hs) {
			if (char.IsDigit(chr)) {
				if (!digito) texto.Append(';');
				texto.Append(chr);
				digito = true;
			} else digito = false;
		}
		WriteLine(texto.ToString());
	}
}

//https://pt.stackoverflow.com/q/320134/101
