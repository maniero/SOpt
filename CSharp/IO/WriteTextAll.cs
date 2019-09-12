try {
    System.IO.File.WriteAllText(@"c:\arquivo.txt", "Matricula");
} catch (IOException ex) {
    WriteLine("deu erro"); //obviamente deve fazer outras coisas aqui
}

catch (Exception ex) when (ex is IOException || 
                           ex is UnauthorizedAccessException || 
                           ex is NotSupportedException || 
                           ex is SecurityException || 
                           ex is DirectoryNotFoundException || 
                           ex is PathTooLongException) {
    WriteLine("deu erro");
}

using (var fileStream = File.OpenRead(@"c:\arquivo.txt")) {
    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize)) {
        while ((var line = streamReader.ReadLine()) != null) {
            //faz algo com a linha
        }
    }
}

//https://pt.stackoverflow.com/q/75848/101
