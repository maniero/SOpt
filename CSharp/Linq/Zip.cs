using static System.Console;
using System.Linq;

public class Program {
    public static void Main() {
        var header = new string[2] { "nome", "endereco" };
        var joao = new string[2] { "joão", "rua santa cruz, 28" };
        var json = header.Zip(joao, (header, data) => "\"" + header + "\" : \"" + data + "\"");
        foreach (var item in json) WriteLine(item);
    }
}

//https://pt.stackoverflow.com/q/436595/101
