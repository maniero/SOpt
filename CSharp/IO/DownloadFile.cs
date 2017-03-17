using (var client = new WebClient()) {
    var tarefa await client.DownloadFileTaskAsync("http://endereco.aqui/arquivo.txt", "arquivo.txt");
}

using (var client = new WebClient()) {
    client.DownloadFile("http://endereco.aqui/arquivo.txt", "arquivo.txt");
}

//http://pt.stackoverflow.com/q/190880/101
