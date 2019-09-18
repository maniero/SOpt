using static System.Console;
					
public class Program {
	public static void Main() {
        var resposta = @"<div class=""nowOnAir"">
            <a href=""http://www.radioitalia.it/artista/edoardo_bennato/1.php"" onclick=""javascript:loadUrl(this.href);return false;"" class=""autore"" title=""Scopri tutto su edoardo bennato"">
                edoardo bennato            </a><br />
            <span>le ragazze fanno grandi sogni</span>

        </div>";
		var inicio = resposta.IndexOf("<span>") + 6;
		var musica = resposta.Substring(inicio, resposta.IndexOf("</span>") - inicio);
		inicio = resposta.IndexOf("autore") + 6;
		var artista = resposta.Substring(inicio, resposta.IndexOf("</a><br />") - inicio);
		WriteLine(musica);
		WriteLine(artista);
	}
}

//https://pt.stackoverflow.com/q/77862/101
