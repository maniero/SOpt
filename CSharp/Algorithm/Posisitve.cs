using static System.Console;

class Program {
    static bool ÉPositivo(int numero) => numero >= 0;
    static void Main() {
        Write("Digite um número: ");
        if (!int.TryParse(ReadLine(), out var numero)) return;
        WriteLine(ÉPositivo(numero));
    }
}

//https://pt.stackoverflow.com/q/416042/101
