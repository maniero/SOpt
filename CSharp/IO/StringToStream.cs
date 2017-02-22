using System.IO;
using System;

public class Program {
    public static void Main() {
		var texto = "meu texto aqui";
        var stream = new MemoryStream();
		StreamWriter writer = new StreamWriter(stream);
		writer.Write(texto);
		writer.Flush();
		stream.Position = 0;
		var reader = new StreamReader(stream);
        var novotexto = reader.ReadToEnd();
        Console.WriteLine(novotexto);
    }
}

//http://pt.stackoverflow.com/q/186048/101
