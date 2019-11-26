var arquivo1 = File.ReadAllBytes(nomeArquivo1);
var arquivo2 = File.ReadAllBytes(nomeArquivo2);
WriteLine(arquivo1.SequenceEqual(arquivo2)); //mostra se é igual ou não

//https://pt.stackoverflow.com/q/109462/101
