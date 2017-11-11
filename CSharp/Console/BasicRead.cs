using static System.Console;

public class Program {
    public static void Main() {
        WriteLine("Digite o ID do artista:");
        if (int.TryParse(ReadLine(), out var numero)) WriteLine($"O tempo {numero} foi adicionado");
    }
}

//https://pt.stackoverflow.com/q/254477/101
