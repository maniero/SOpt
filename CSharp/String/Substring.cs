using static System.Console;

public class Program {
    static void Main() {
        var url = "http://abc.com";
        var posicao = url.IndexOf(':');
        if (posicao < 0) return; //aqui você trata como quiser se não achar a string
        WriteLine(url.Substring(posicao));
        WriteLine(url[posicao..]); //só para C# 8
    }
}

//https://pt.stackoverflow.com/q/359110/101
