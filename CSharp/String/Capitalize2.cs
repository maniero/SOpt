using System.Text;
					
System.Console.WriteLine("|" + Capitalizar("   JOSÉ   DA COSTA DOS PEREIRAS E SILVA   ") + "|");

static string Capitalizar(string texto) {
	StringBuilder novo = new(texto.Length);
	for (var i = 0; i < texto.Length; i++) {
		var atual = char.ToLower(texto[i]);
		var anterior = i == 0 ? ' ' : char.ToLower(texto[i - 1]);
		var proximo = i > texto.Length - 2 ? 0 : char.ToLower(texto[i + 1]);
		var segundo = i > texto.Length - 3 ? 0 : char.ToLower(texto[i + 2]);
		var terceiro = i > texto.Length - 4 ? 0 : char.ToLower(texto[i + 3]);
		if (atual == ' ' && anterior == ' ') continue;
		if (anterior != ' ' ||
			(atual == 'e' && proximo == ' ') ||
			(atual == 'd' &&
			((proximo == 'a' || proximo == 'e' || proximo == 'o') && (segundo == ' ')) ||
			((proximo == 'a' || proximo == 'o') && (segundo == 's') && (terceiro == ' '))
			)) novo.Append(atual);
		else novo.Append(char.ToUpper(atual));
	}
	if (novo[novo.Length - 1] == ' ') novo.Remove(novo.Length - 1, 1);
	return novo.ToString();
}

//https://pt.stackoverflow.com/q/247/101
