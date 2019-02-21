using static System.Console;
public class Program {
	public static void Main() {
        var texto = "0001>0002>0003>0004>0005";
		var posicao = -1;
        for (var i = 0; i < 3; i++) {
			posicao = texto.IndexOf(">", posicao + 1);
			if (posicao == -1) break;
		}
        if (posicao > -1) texto = texto.Substring(0, posicao);
        WriteLine(texto);
        texto = "0001>0002";
		posicao = -1;
        for (var i = 0; i < 3; i++) {
			posicao = texto.IndexOf(">", posicao + 1);
			if (posicao == -1) break;
		}
        if (posicao > -1) texto = texto.Substring(0, posicao);
        WriteLine(texto);
    }
}

//https://pt.stackoverflow.com/q/363960/101
