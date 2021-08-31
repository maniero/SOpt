void Metodo() {
    ...
    using (var arquivo = CriaRecurso()) { ... }
    ...
}

FileStream CriaRecurso() {
    ...
    var file = new FileStream("abc.txt", FileMode.Create)
    ...
    return file;
}

using static System.Console;
using System.Net.Http;

public class Program {
    public static async Task Main() {
        WriteLine("Starting connections");
        for (int i = 0; i<10; i++) {
            using (var client = new HttpClient()) {
                var result = await client.GetAsync("http://aspnetmonsters.com");
                WriteLine(result.StatusCode);
            }
        }
        WriteLine("Connections done");
    }
}
using static System.Console;
using System.Net.Http;

public class Program {
    private static HttpClient Client = new HttpClient();
    public static async Task Main() {
        WriteLine("Starting connections");
        for (int i = 0; i<10; i++) {
            var result = await client.GetAsync("http://aspnetmonsters.com");
            WriteLine(result.StatusCode);
        }
        WriteLine("Connections done");
    }
}

//https://pt.stackoverflow.com/q/422717/101
