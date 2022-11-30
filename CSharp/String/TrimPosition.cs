using static System.Console;

const int MaxTamanhoEndereco = 30;
WriteLine(TrimPosition("AvenidaAventureirosAfortunados, 1234", MaxTamanhoEndereco));
WriteLine(TrimPosition("Rua Aventureiros Afortunados, 12345", MaxTamanhoEndereco));
WriteLine(TrimPosition("Av Aventureiros Afortunados, 12345", MaxTamanhoEndereco));
WriteLine(TrimPosition("R Aventureiros Afortunados, 12345", MaxTamanhoEndereco));
WriteLine(TrimPosition(" Aventureiros Afortunados, 12345", MaxTamanhoEndereco));
WriteLine(TrimPosition("Aventureiros Afortunados, 12345", MaxTamanhoEndereco));
WriteLine(TrimPosition("Aventureiros Afortunados, 1234", MaxTamanhoEndereco));

static string TrimPosition(string text, int limit, string specialChars = " ,.", string trimMarker = "...") {
	if (text.Length > limit) {
		var markerLength = trimMarker.Length;
		var isSpecial = specialChars.Contains(text.Substring(limit - markerLength, 1));
		text = text.Substring(0, limit - markerLength);
		var posicaoUltimoEspaco = text.LastIndexOfAny(specialChars.ToCharArray());
		text = ((posicaoUltimoEspaco > 0 && !isSpecial) ? text.Substring(0, posicaoUltimoEspaco) : text) + trimMarker;
	}
	return text;
}

//https://pt.stackoverflow.com/q/114959/101
