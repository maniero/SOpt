public static void AddFile(string texto) {
    int pos = texto.IndexOf("\"") + 1; //se achar nada causará erro
    var entreAspas = texto.Substring(pos, texto.IndexOf("\"", pos) - valorPos);
    texto = texto.Substring(texto.IndexOf("\"", valorPos) + 1);
    var palavras = texto.Split(' ');
    Globals.Files.Add(new Globals.File { Name = entreAspas, Hash = palavras[0], Size = Convert.ToInt64(palavras[1]));
}

//https://pt.stackoverflow.com/q/386560/101
