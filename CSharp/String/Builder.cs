using static System.Console;
using System.Text;

public class Program {
    public static void Main() {
        WriteLine("Digite uma frase: ");
        var frase = ReadLine();
        WriteLine($"Original string: {frase}");
        var invertida = new StringBuilder(frase.Length);
        foreach (var chr in frase) invertida.Append(char.ToLower(chr == ' ' ? '0' : chr));
        WriteLine($"Character array: {invertida}");
    }
}

//https://pt.stackoverflow.com/q/325081/101
